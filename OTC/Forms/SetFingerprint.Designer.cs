namespace OTC.Forms
{
    partial class SetFingerprint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetFingerprint));
            this.outerGroupBox = new System.Windows.Forms.GroupBox();
            this.lblDocumentNumberResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddressResult = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumberResult = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblNameResult = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.innerGroupBox = new System.Windows.Forms.GroupBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.picFingerprint = new System.Windows.Forms.PictureBox();
            this.txtDocumentNumberSearch = new System.Windows.Forms.TextBox();
            this.lblDocumentNumberSearch = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.outerGroupBox.SuspendLayout();
            this.innerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerprint)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outerGroupBox
            // 
            this.outerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outerGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.outerGroupBox.Controls.Add(this.lblDocumentNumberResult);
            this.outerGroupBox.Controls.Add(this.label1);
            this.outerGroupBox.Controls.Add(this.lblAddressResult);
            this.outerGroupBox.Controls.Add(this.lblAddress);
            this.outerGroupBox.Controls.Add(this.lblPhoneNumberResult);
            this.outerGroupBox.Controls.Add(this.lblPhoneNumber);
            this.outerGroupBox.Controls.Add(this.lblNameResult);
            this.outerGroupBox.Controls.Add(this.lblName);
            this.outerGroupBox.Controls.Add(this.btnSearch);
            this.outerGroupBox.Controls.Add(this.innerGroupBox);
            this.outerGroupBox.Controls.Add(this.txtDocumentNumberSearch);
            this.outerGroupBox.Controls.Add(this.lblDocumentNumberSearch);
            this.outerGroupBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.outerGroupBox.Name = "outerGroupBox";
            this.outerGroupBox.Size = new System.Drawing.Size(440, 469);
            this.outerGroupBox.TabIndex = 0;
            this.outerGroupBox.TabStop = false;
            this.outerGroupBox.Text = "Staff Member Search";
            // 
            // lblDocumentNumberResult
            // 
            this.lblDocumentNumberResult.AutoSize = true;
            this.lblDocumentNumberResult.Location = new System.Drawing.Point(112, 61);
            this.lblDocumentNumberResult.Name = "lblDocumentNumberResult";
            this.lblDocumentNumberResult.Size = new System.Drawing.Size(0, 14);
            this.lblDocumentNumberResult.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Document #:";
            // 
            // lblAddressResult
            // 
            this.lblAddressResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddressResult.AutoSize = true;
            this.lblAddressResult.Location = new System.Drawing.Point(112, 142);
            this.lblAddressResult.Name = "lblAddressResult";
            this.lblAddressResult.Size = new System.Drawing.Size(0, 14);
            this.lblAddressResult.TabIndex = 13;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 142);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 14);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhoneNumberResult
            // 
            this.lblPhoneNumberResult.AutoSize = true;
            this.lblPhoneNumberResult.Location = new System.Drawing.Point(112, 116);
            this.lblPhoneNumberResult.Name = "lblPhoneNumberResult";
            this.lblPhoneNumberResult.Size = new System.Drawing.Size(0, 14);
            this.lblPhoneNumberResult.TabIndex = 11;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 116);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(83, 14);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblNameResult
            // 
            this.lblNameResult.AutoSize = true;
            this.lblNameResult.Location = new System.Drawing.Point(112, 88);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(0, 14);
            this.lblNameResult.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 14);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(349, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // innerGroupBox
            // 
            this.innerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.innerGroupBox.Controls.Add(this.lblInstructions);
            this.innerGroupBox.Controls.Add(this.btnScan);
            this.innerGroupBox.Controls.Add(this.picFingerprint);
            this.innerGroupBox.Location = new System.Drawing.Point(6, 179);
            this.innerGroupBox.Name = "innerGroupBox";
            this.innerGroupBox.Size = new System.Drawing.Size(428, 266);
            this.innerGroupBox.TabIndex = 6;
            this.innerGroupBox.TabStop = false;
            this.innerGroupBox.Text = "Fingerprint Scanning";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(6, 246);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(72, 14);
            this.lblInstructions.TabIndex = 7;
            this.lblInstructions.Text = "(Instructions)";
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScan.Enabled = false;
            this.btnScan.Image = global::OTC.Properties.Resources.fingerprint_icon;
            this.btnScan.Location = new System.Drawing.Point(9, 37);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(166, 194);
            this.btnScan.TabIndex = 3;
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // picFingerprint
            // 
            this.picFingerprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picFingerprint.Location = new System.Drawing.Point(265, 37);
            this.picFingerprint.Name = "picFingerprint";
            this.picFingerprint.Size = new System.Drawing.Size(153, 194);
            this.picFingerprint.TabIndex = 5;
            this.picFingerprint.TabStop = false;
            // 
            // txtDocumentNumberSearch
            // 
            this.txtDocumentNumberSearch.Location = new System.Drawing.Point(96, 24);
            this.txtDocumentNumberSearch.Name = "txtDocumentNumberSearch";
            this.txtDocumentNumberSearch.Size = new System.Drawing.Size(179, 22);
            this.txtDocumentNumberSearch.TabIndex = 1;
            this.txtDocumentNumberSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocumentNumberSearch_KeyDown);
            // 
            // lblDocumentNumberSearch
            // 
            this.lblDocumentNumberSearch.AutoSize = true;
            this.lblDocumentNumberSearch.Location = new System.Drawing.Point(20, 28);
            this.lblDocumentNumberSearch.Name = "lblDocumentNumberSearch";
            this.lblDocumentNumberSearch.Size = new System.Drawing.Size(70, 14);
            this.lblDocumentNumberSearch.TabIndex = 2;
            this.lblDocumentNumberSearch.Text = "Document #:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Update User Fingerprint";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(267, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTitle,
            this.statusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(463, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusTitle
            // 
            this.statusTitle.Name = "statusTitle";
            this.statusTitle.Size = new System.Drawing.Size(80, 17);
            this.statusTitle.Text = "Reader status:";
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(57, 17);
            this.statusMessage.Text = "Waiting...";
            // 
            // SetFingerprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 544);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.outerGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetFingerprint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Fingerprint Creation";
            this.outerGroupBox.ResumeLayout(false);
            this.outerGroupBox.PerformLayout();
            this.innerGroupBox.ResumeLayout(false);
            this.innerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerprint)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox outerGroupBox;
        private System.Windows.Forms.TextBox txtDocumentNumberSearch;
        private System.Windows.Forms.Label lblDocumentNumberSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picFingerprint;
        private System.Windows.Forms.GroupBox innerGroupBox;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusTitle;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.Label lblAddressResult;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumberResult;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblNameResult;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDocumentNumberResult;
        private System.Windows.Forms.Label label1;
    }
}