namespace OTC
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFingerprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo1 = new System.Windows.Forms.PictureBox();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.punchingToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(428, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffMembersToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // staffMembersToolStripMenuItem
            // 
            this.staffMembersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setFingerprintToolStripMenuItem});
            this.staffMembersToolStripMenuItem.Name = "staffMembersToolStripMenuItem";
            this.staffMembersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.staffMembersToolStripMenuItem.Text = "&Staff Members";
            this.staffMembersToolStripMenuItem.Click += new System.EventHandler(this.staffMembersToolStripMenuItem_Click);
            // 
            // setFingerprintToolStripMenuItem
            // 
            this.setFingerprintToolStripMenuItem.Name = "setFingerprintToolStripMenuItem";
            this.setFingerprintToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setFingerprintToolStripMenuItem.Text = "&Update Fingerprint";
            this.setFingerprintToolStripMenuItem.Click += new System.EventHandler(this.setFingerprintToolStripMenuItem_Click);
            // 
            // punchingToolStripMenuItem
            // 
            this.punchingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerPunchToolStripMenuItem});
            this.punchingToolStripMenuItem.Name = "punchingToolStripMenuItem";
            this.punchingToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.punchingToolStripMenuItem.Text = "&Punching";
            // 
            // registerPunchToolStripMenuItem
            // 
            this.registerPunchToolStripMenuItem.Name = "registerPunchToolStripMenuItem";
            this.registerPunchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerPunchToolStripMenuItem.Text = "&Open";
            this.registerPunchToolStripMenuItem.Click += new System.EventHandler(this.registerPunchToolStripMenuItem_Click);
            // 
            // picLogo1
            // 
            this.picLogo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo1.ErrorImage = null;
            this.picLogo1.Image = ((System.Drawing.Image)(resources.GetObject("picLogo1.Image")));
            this.picLogo1.InitialImage = null;
            this.picLogo1.Location = new System.Drawing.Point(12, 41);
            this.picLogo1.Name = "picLogo1";
            this.picLogo1.Size = new System.Drawing.Size(404, 281);
            this.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo1.TabIndex = 1;
            this.picLogo1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(428, 347);
            this.Controls.Add(this.picLogo1);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTC v1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerPunchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setFingerprintToolStripMenuItem;
        private System.Windows.Forms.PictureBox picLogo1;
    }
}

