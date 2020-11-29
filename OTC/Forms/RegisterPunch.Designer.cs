namespace OTC
{
    partial class RegisterPunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPunch));
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.innerGroupBox = new System.Windows.Forms.GroupBox();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.lblPunchDateTime = new System.Windows.Forms.Label();
            this.lblPunchDateTimeResult = new System.Windows.Forms.Label();
            this.lblPunchType = new System.Windows.Forms.Label();
            this.lblPunchTypeResult = new System.Windows.Forms.Label();
            this.lblStaffMemberName = new System.Windows.Forms.Label();
            this.lblStaffMemberNameResult = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.picFingerprint = new System.Windows.Forms.PictureBox();
            this.outerGroupBox = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.innerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerprint)).BeginInit();
            this.outerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(706, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 42);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusResult});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(867, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel.Text = "Scanner status:";
            // 
            // toolStripStatusResult
            // 
            this.toolStripStatusResult.Name = "toolStripStatusResult";
            this.toolStripStatusResult.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusResult.Text = "Waiting...";
            // 
            // innerGroupBox
            // 
            this.innerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.innerGroupBox.Controls.Add(this.picCheck);
            this.innerGroupBox.Controls.Add(this.lblPunchDateTime);
            this.innerGroupBox.Controls.Add(this.lblPunchDateTimeResult);
            this.innerGroupBox.Controls.Add(this.lblPunchType);
            this.innerGroupBox.Controls.Add(this.lblPunchTypeResult);
            this.innerGroupBox.Controls.Add(this.lblStaffMemberName);
            this.innerGroupBox.Controls.Add(this.lblStaffMemberNameResult);
            this.innerGroupBox.Controls.Add(this.lblInstructions);
            this.innerGroupBox.Controls.Add(this.picFingerprint);
            this.innerGroupBox.Location = new System.Drawing.Point(6, 21);
            this.innerGroupBox.Name = "innerGroupBox";
            this.innerGroupBox.Size = new System.Drawing.Size(813, 288);
            this.innerGroupBox.TabIndex = 6;
            this.innerGroupBox.TabStop = false;
            this.innerGroupBox.Text = "Read fingerprint";
            // 
            // picCheck
            // 
            this.picCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCheck.Image = ((System.Drawing.Image)(resources.GetObject("picCheck.Image")));
            this.picCheck.Location = new System.Drawing.Point(666, 72);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(141, 136);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheck.TabIndex = 7;
            this.picCheck.TabStop = false;
            this.picCheck.Visible = false;
            // 
            // lblPunchDateTime
            // 
            this.lblPunchDateTime.AutoSize = true;
            this.lblPunchDateTime.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunchDateTime.Location = new System.Drawing.Point(158, 168);
            this.lblPunchDateTime.Name = "lblPunchDateTime";
            this.lblPunchDateTime.Size = new System.Drawing.Size(123, 29);
            this.lblPunchDateTime.TabIndex = 13;
            this.lblPunchDateTime.Text = "Date/time:";
            // 
            // lblPunchDateTimeResult
            // 
            this.lblPunchDateTimeResult.AutoSize = true;
            this.lblPunchDateTimeResult.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunchDateTimeResult.Location = new System.Drawing.Point(162, 197);
            this.lblPunchDateTimeResult.Name = "lblPunchDateTimeResult";
            this.lblPunchDateTimeResult.Size = new System.Drawing.Size(39, 36);
            this.lblPunchDateTimeResult.TabIndex = 12;
            this.lblPunchDateTimeResult.Text = "...";
            this.lblPunchDateTimeResult.Visible = false;
            // 
            // lblPunchType
            // 
            this.lblPunchType.AutoSize = true;
            this.lblPunchType.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunchType.Location = new System.Drawing.Point(158, 103);
            this.lblPunchType.Name = "lblPunchType";
            this.lblPunchType.Size = new System.Drawing.Size(67, 29);
            this.lblPunchType.TabIndex = 11;
            this.lblPunchType.Text = "Type:";
            // 
            // lblPunchTypeResult
            // 
            this.lblPunchTypeResult.AutoSize = true;
            this.lblPunchTypeResult.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunchTypeResult.Location = new System.Drawing.Point(162, 132);
            this.lblPunchTypeResult.Name = "lblPunchTypeResult";
            this.lblPunchTypeResult.Size = new System.Drawing.Size(39, 36);
            this.lblPunchTypeResult.TabIndex = 10;
            this.lblPunchTypeResult.Text = "...";
            this.lblPunchTypeResult.Visible = false;
            // 
            // lblStaffMemberName
            // 
            this.lblStaffMemberName.AutoSize = true;
            this.lblStaffMemberName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffMemberName.Location = new System.Drawing.Point(158, 38);
            this.lblStaffMemberName.Name = "lblStaffMemberName";
            this.lblStaffMemberName.Size = new System.Drawing.Size(157, 29);
            this.lblStaffMemberName.TabIndex = 9;
            this.lblStaffMemberName.Text = "Staff Member:";
            // 
            // lblStaffMemberNameResult
            // 
            this.lblStaffMemberNameResult.AutoSize = true;
            this.lblStaffMemberNameResult.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffMemberNameResult.Location = new System.Drawing.Point(162, 67);
            this.lblStaffMemberNameResult.Name = "lblStaffMemberNameResult";
            this.lblStaffMemberNameResult.Size = new System.Drawing.Size(39, 36);
            this.lblStaffMemberNameResult.TabIndex = 8;
            this.lblStaffMemberNameResult.Text = "...";
            this.lblStaffMemberNameResult.Visible = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(13, 258);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(72, 14);
            this.lblInstructions.TabIndex = 7;
            this.lblInstructions.Text = "(Instructions)";
            // 
            // picFingerprint
            // 
            this.picFingerprint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picFingerprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFingerprint.Location = new System.Drawing.Point(16, 37);
            this.picFingerprint.Name = "picFingerprint";
            this.picFingerprint.Size = new System.Drawing.Size(136, 195);
            this.picFingerprint.TabIndex = 5;
            this.picFingerprint.TabStop = false;
            // 
            // outerGroupBox
            // 
            this.outerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outerGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.outerGroupBox.Controls.Add(this.innerGroupBox);
            this.outerGroupBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.outerGroupBox.Name = "outerGroupBox";
            this.outerGroupBox.Size = new System.Drawing.Size(825, 314);
            this.outerGroupBox.TabIndex = 1;
            this.outerGroupBox.TabStop = false;
            this.outerGroupBox.Text = "Staff member info";
            // 
            // RegisterPunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 399);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.outerGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterPunch";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punch In/Out";
            this.Load += new System.EventHandler(this.RegisterPunch_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.innerGroupBox.ResumeLayout(false);
            this.innerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerprint)).EndInit();
            this.outerGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusResult;
        private System.Windows.Forms.GroupBox innerGroupBox;
        private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.Label lblPunchDateTime;
        private System.Windows.Forms.Label lblPunchDateTimeResult;
        private System.Windows.Forms.Label lblPunchType;
        private System.Windows.Forms.Label lblPunchTypeResult;
        private System.Windows.Forms.Label lblStaffMemberName;
        private System.Windows.Forms.Label lblStaffMemberNameResult;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox picFingerprint;
        private System.Windows.Forms.GroupBox outerGroupBox;
    }
}