using DPFP;
using MongoDB.Bson;
using MongoDB.Driver;
using OTC.DTO;
using OTC.Properties;
using OTC.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace OTC
{
    public partial class RegisterPunch : Form, DPFP.Capture.EventHandler
    {
        #region Private Properties
        delegate void Function();
        private DPFP.Capture.Capture Capturer;
        private DPFP.Processing.Enrollment Enroller;
        private DPFP.Verification.Verification Verificator;
        private DPFP.Sample MemSample;
        private DPFP.Template template;
        private DTO.StaffMember staffMember;

        private MongoClient dbClient;
        private IMongoDatabase db;
        private IMongoCollection<BsonDocument> collection;
        private BsonDocument currentStaffMember;
            
        private XmlDocument environmentSettingsXml = new XmlDocument();
        private string settingsPath = Path.GetFullPath("Config/EnvironmentSettings.xml");
        private string databaseUrl;
        private string databaseName;
        private string punchesTable;
        #endregion

        #region Constructors
        public RegisterPunch()
        {
            InitializeComponent();
            Verificator = new DPFP.Verification.Verification();
            InitDatabase();
        }
        #endregion

        #region Private Methods
        private void InitDatabase()
        {
            environmentSettingsXml.Load(settingsPath);

            databaseUrl = environmentSettingsXml.SelectSingleNode("//database/url").InnerText;
            databaseName = environmentSettingsXml.SelectSingleNode("//database/name").InnerText;
            punchesTable = environmentSettingsXml.SelectSingleNode("//database/punches_table_name").InnerText;

            dbClient = new MongoClient(databaseUrl);
            db = dbClient.GetDatabase(databaseName);
            collection = db.GetCollection<BsonDocument>(punchesTable);
        }

        private void SavePunch(Punch punch)
        {
            var document = new BsonDocument {
                { "type", punch.type },
                { "documentNumber", punch.documentNumber },
                { "createdAt", DateTime.Now },
            };

            collection.InsertOne(document);
        }

        private void ClearFields()
        {
            if (picCheck.InvokeRequired)
            {
                picCheck.BeginInvoke((MethodInvoker)delegate
                {
                    picCheck.Visible = false;
                });
            }

            if (picFingerprint.InvokeRequired)
            {
                picFingerprint.BeginInvoke((MethodInvoker)delegate
                {
                    picFingerprint.Image = null;
                });
            }

            if (lblPunchDateTimeResult.InvokeRequired)
            {
                lblPunchDateTimeResult.BeginInvoke((MethodInvoker)delegate
                {
                    lblPunchDateTimeResult.Text = "";
                });
            }
            if (lblInstructions.InvokeRequired)
            {
                lblInstructions.BeginInvoke((MethodInvoker)delegate
                {
                    lblInstructions.Text = "";
                });
            }
            if (lblStaffMemberNameResult.InvokeRequired)
            {
                lblStaffMemberNameResult.BeginInvoke((MethodInvoker)delegate
                {
                    lblStaffMemberNameResult.Text = "";
                });
            }
            if (lblPunchTypeResult.InvokeRequired)
            {
                lblPunchTypeResult.BeginInvoke((MethodInvoker)delegate
                {
                    lblPunchTypeResult.Text = "";
                });
            }

            MemSample = null;
        }

        private void ScanListener()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();

                if (null != Capturer)
                {
                    Capturer.EventHandler = this;
                    Enroller = new DPFP.Processing.Enrollment();
                    if (null != Capturer)
                    {
                        try
                        {
                            Capturer.StartCapture();
                            SetStatus("Place you index finger on the reader");
                        }
                        catch
                        {
                            MakeReport("Fingerprint reading could not start!");
                        }
                    }
                }
                else
                {
                    MakeReport("Fingerprint reading could not start!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "OTC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
                picFingerprint.Image = new Bitmap(bitmap, picFingerprint.Size);
            }));
        }
        #endregion

        #region Protected Methods
        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate ()
            {
                this.toolStripStatusResult.Text = message;
            }));
        }

        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate ()
            {
                this.lblInstructions.Text = status;
            }));
        }

        protected void Process(DPFP.Sample Sample)
        {
            try
            {
                MemSample = Sample;
                DrawPicture(ConvertSampleToBitmap(Sample));
            }
            catch (Exception ex)
            {
                MakeReport(ex.Message);
            }
        }

        protected void Compare(Template template, Sample sample, string type)
        {
            DPFP.FeatureSet features = ExtractFeatures(sample, DPFP.Processing.DataPurpose.Verification);
            DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

            XmlSerial serial = new XmlSerial();
            XmlDocument xmlDoc = new XmlDocument();

            string path = Path.GetFullPath("DB/StaffRepository.xml");

            xmlDoc.Load(path);
            StaffMemberList staffMembers = serial.DeserializeObject<StaffMemberList>(xmlDoc.InnerXml);

            foreach (DTO.StaffMember staffMember in staffMembers.staffMemberList)
            {
                MemoryStream ms = new MemoryStream(staffMember.fingerprintTemplateBytes);
                template = new DPFP.Template(ms);
                Verificator.Verify(features, template, ref result);

                XmlSerial punchSerial = new XmlSerial();
                XmlDocument punchXmlDoc = new XmlDocument();
                Punch punch = new DTO.Punch();

                string newPunchType = "";
                string punchXmlizedString = punchSerial.SerializeObject(punch);
                string punchPath = Path.GetFullPath("DB/PunchRepository.xml");

                punchXmlDoc.Load(punchPath);

                PunchList punches = punchSerial.DeserializeObject<PunchList>(punchXmlDoc.InnerXml);

                List<Punch> punchList = punches.punchList.ToList();
                punch = new DTO.Punch();

                if (punchList.Where(p => p.documentNumber == staffMember.documentNumber).Count() > 0)
                {
                    var val = punches.punchList.Where(p => p.documentNumber == staffMember.documentNumber).Last();
                    if (val.type == "I")
                    {
                        newPunchType = "O";
                    }
                    else if (val.type == "O")
                    {
                        newPunchType = "I";
                    }

                }
                else
                {
                    newPunchType = "I";
                }

                punch.type = newPunchType;
                punch.documentNumber = staffMember.documentNumber;
                punch.createdAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                punchList.Add(punch);
                punches.punchList = punchList.ToArray();

                punchXmlizedString = punchSerial.SerializeObject<PunchList>(punches);
                punchXmlDoc = new XmlDocument();
                punchXmlDoc.InnerXml = punchXmlizedString;

                if (features != null)
                {
                    if (result.Verified)
                    {
                        if (lblStaffMemberNameResult.InvokeRequired)
                        {
                            lblStaffMemberNameResult.BeginInvoke((MethodInvoker)delegate
                            {
                                lblStaffMemberNameResult.Visible = true;
                                lblStaffMemberNameResult.Text = staffMember.name;
                            });
                        }

                        if (lblPunchDateTimeResult.InvokeRequired)
                        {
                            lblPunchDateTimeResult.BeginInvoke((MethodInvoker)delegate
                            {
                                lblPunchDateTimeResult.Visible = true;
                                lblPunchDateTimeResult.Text = DateTime.Now.ToString("HH:mm:ss");

                                if (punch.type == "I")
                                {
                                    lblPunchTypeResult.ForeColor = System.Drawing.Color.Blue;
                                    lblPunchTypeResult.Visible = true;
                                    lblPunchTypeResult.Text = "IN";
                                }
                                else if (punch.type == "O")
                                {
                                    lblPunchTypeResult.ForeColor = System.Drawing.Color.Red;
                                    lblPunchTypeResult.Visible = true;
                                    lblPunchTypeResult.Text = "OUT";
                                }
                                else
                                {
                                    lblPunchTypeResult.ForeColor = System.Drawing.Color.Blue;
                                    lblPunchTypeResult.Text = "IN";
                                }
                            });
                        }

                        if (picCheck.InvokeRequired)
                        {
                            picCheck.BeginInvoke((MethodInvoker)delegate
                            {
                                picCheck.Visible = true;
                                picCheck.Image = (Image)Resources.ResourceManager.GetObject("check");
                            });
                        }
                        System.Media.SystemSounds.Beep.Play();

                        punchXmlDoc.Save(punchPath);
                        SavePunch(punch);
                    }
                }
            }
            Thread.Sleep(1000);
            ClearFields();
        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
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
        #endregion

        #region Reader Events
        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            SetStatus("Fingerprint scanned successfully!");
            MakeReport("Fingerprint scanned successfully!");
            Process(Sample);
            Compare(template, MemSample, "");
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Waiting...");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Validating...");
            Thread.Sleep(2000);
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
                MakeReport("Fingerprint reading quality: OK");
            else
                MakeReport("Fingerprint reading quality: NOT OK");
        }
        #endregion

        #region Form Events
        private void RegisterPunch_Load(object sender, EventArgs e)
        {
            ScanListener();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Capturer != null)
                Capturer.StopCapture();
            this.Close();
        }
        #endregion
    }
}
