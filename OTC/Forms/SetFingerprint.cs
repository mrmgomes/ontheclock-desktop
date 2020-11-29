using MongoDB.Bson;
using MongoDB.Driver;
using OTC.DTO;
using OTC.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace OTC.Forms
{
    delegate void Function();

    public partial class SetFingerprint : Form, DPFP.Capture.EventHandler
    {
        #region Private Properties
        private DPFP.Capture.Capture Capturer;
        private DPFP.Processing.Enrollment Enroller;
        private DPFP.Sample MemSample;
        private DPFP.Template MemTemplate;
        private DPFP.Verification.Verification Verificator;

        private MongoClient dbClient;
        private IMongoDatabase db;
        private IMongoCollection<BsonDocument> collection;
        private BsonDocument currentStaffMember;

        private XmlDocument environmentSettingsXml = new XmlDocument();
        private string settingsPath = Path.GetFullPath("Config/EnvironmentSettings.xml");
        private string databaseUrl;
        private string databaseName;
        private string staffTable;
        #endregion

        #region Constructors
        public SetFingerprint()
        {
            try
            {
                InitializeComponent();
                Enroller = new DPFP.Processing.Enrollment();
                Verificator = new DPFP.Verification.Verification();
                InitDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "OTC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Private Methods
        private void InitDatabase()
        {
            environmentSettingsXml.Load(settingsPath);

            databaseUrl = environmentSettingsXml.SelectSingleNode("//database/url").InnerText;
            databaseName = environmentSettingsXml.SelectSingleNode("//database/name").InnerText;
            staffTable = environmentSettingsXml.SelectSingleNode("//database/staff_table_name").InnerText;

            dbClient = new MongoClient(databaseUrl);
            db = dbClient.GetDatabase(databaseName);
            
            collection = db.GetCollection<BsonDocument>(staffTable);
        }

        private void ClearFields()
        {
            picFingerprint.Visible = false;
            picFingerprint.Image = null;
            lblInstructions.Text = "";
            txtDocumentNumberSearch.Text = "";
            MemSample = null;

            txtDocumentNumberSearch.Select();
        }

        private void SearchUserByDocumentNumber(String documentNumber)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("documentNumber", documentNumber);
            var document = collection.Find(filter).FirstOrDefault();

            if (document != null)
            {
                currentStaffMember = document;
                UpdateFields(currentStaffMember);
                btnScan.Enabled = true;
            }
        }

        private void UpdateStaffFingerprint(BsonDocument document)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", document.GetElement("_id").Value);
            var update = Builders<BsonDocument>.Update
                .Set("fingerprint", true)
                .Set("updatedAt", DateTime.Now);

            collection.UpdateOne(filter, update);
        }

        private void UpdateFields(BsonDocument document)
        {
            lblNameResult.Text = document.GetElement("name").Value.ToString();
            lblPhoneNumberResult.Text = document.GetElement("phoneNumber").Value.ToString();
            lblAddressResult.Text = document.GetElement("address").Value.ToString();
            lblDocumentNumberResult.Text = document.GetElement("documentNumber").Value.ToString();
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
                picFingerprint.Image = new Bitmap(bitmap, picFingerprint.Size);
            }));
        }

        private void EnabledDisabledButton(bool enabled)
        {
            this.Invoke(new Function(delegate ()
            {
                this.btnSave.Enabled = enabled;
            }));
        }
        #endregion

        #region Protected Methods
        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate ()
            {
                this.statusMessage.Text = message;
            }));
        }

        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate ()
            {
                this.lblInstructions.Text = status;
            }));
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected void Process(DPFP.Sample Sample)
        {
            MemSample = Sample;

            //SearchUserByFingerprint(MemSample);
            DrawPicture(ConvertSampleToBitmap(Sample));
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            if (features != null)
            {
                try
                {
                    MakeReport("Fingerprint sample collected.");
                    Enroller.AddFeatures(features);
                }
                finally
                {
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:
                            MemTemplate = Enroller.Template;
                            EnabledDisabledButton(true);
                            break;
                        case DPFP.Processing.Enrollment.Status.Failed:
                            SetStatus(string.Format("{0} samples left!", Enroller.FeaturesNeeded));
                            Enroller.Clear();
                            MemTemplate = null;
                            EnabledDisabledButton(false);
                            break;
                        case DPFP.Processing.Enrollment.Status.Insufficient:
                            SetStatus(string.Format("{0} samples left!", Enroller.FeaturesNeeded));
                            EnabledDisabledButton(false);
                            break;
                    }
                }
            }
        }
        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }
        #endregion

        #region Reader Events
        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            SetStatus("Fingerprint scanned successfully!");
            MakeReport("Fingerprint has been collected successfully!");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Finger removed from reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Finger detected on reader.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Fingerprint reader connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Fingerprint reader disconnected.");
        }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("Fingerprint quality: OK");
            else
                MakeReport("Fingerprint quality: NOT OK");
        }
        #endregion

        #region Form Events
        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();

                if (null != Capturer)
                {
                    Capturer.EventHandler = this;
                    //Enroller = new DPFP.Processing.Enrollment();
                    if (null != Capturer)
                    {
                        try
                        {
                            Capturer.StartCapture();
                            SetStatus("Place your index finder on the reader");
                        }
                        catch
                        {
                            MakeReport("Failed to scan");
                        }
                    }
                }
                else
                {
                    MakeReport("Failed to scan!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "OTC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Capturer != null)
                Capturer.StopCapture();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtDocumentNumberSearch.Text) || String.IsNullOrEmpty(txtDocumentNumberSearch.Text))
            {
                MessageBox.Show("Please fill in all required fields");
            }
            else
            {
                try
                {
                    XmlSerial serial = new XmlSerial();
                    DTO.StaffMember staffMember = new DTO.StaffMember();

                    staffMember.name = this.lblNameResult.Text;
                    staffMember.documentNumber = this.lblDocumentNumberResult.Text;
                    staffMember.fingerprint = Functions.ImageToByteArray(this.picFingerprint.Image);
                    staffMember.fingerprintTemplateBytes = MemTemplate.Bytes;
                    staffMember.fingerprintTemplateSize = MemTemplate.Size;

                    String XmlizedString = serial.SerializeObject(staffMember);

                    XmlDocument xmlDoc = new XmlDocument();
                    string path = Path.GetFullPath("DB/StaffRepository.xml");

                    xmlDoc.Load(path);

                    StaffMemberList staffMembers = serial.DeserializeObject<StaffMemberList>(xmlDoc.InnerXml);

                    if (staffMembers.staffMemberList != null)
                    {
                        if (staffMembers.staffMemberList.Where(s => s.documentNumber == staffMember.documentNumber).Count() > 0)
                        {
                            var val = staffMembers.staffMemberList.Where(s => s.documentNumber == staffMember.documentNumber).FirstOrDefault();
                            val.name = staffMember.name;
                            val.fingerprint = staffMember.fingerprint;
                        }
                        else
                        {
                            List<DTO.StaffMember> smList = staffMembers.staffMemberList.ToList();
                            smList.Add(staffMember);
                            staffMembers.staffMemberList = smList.ToArray();
                        }
                    }
                    else
                    {
                        List<DTO.StaffMember> smList = new List<DTO.StaffMember>();
                        smList.Add(staffMember);
                        staffMembers.staffMemberList = smList.ToArray();
                    }

                    XmlizedString = serial.SerializeObject<StaffMemberList>(staffMembers);
                    xmlDoc = new XmlDocument();
                    xmlDoc.InnerXml = XmlizedString;

                    if (File.Exists(path))
                        File.Delete(path);

                    xmlDoc.Save(path);

                    byte[] fingerprint = Functions.ImageToByteArray(this.picFingerprint.Image);
                    UpdateStaffFingerprint(currentStaffMember);

                    MessageBox.Show(this, "Staff member updated successfully!", "OTC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, string.Format("Error trying to save the staff member. Exception: {0}", ex.Message),
                        "OTC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUserByDocumentNumber(txtDocumentNumberSearch.Text);
        }

        private void txtDocumentNumberSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }
        #endregion
    }
}
