using OTC.Forms;
using System;
using System.Windows.Forms;

namespace OTC
{
    delegate void Function();
    public partial class Main : Form
    {
        #region Constructors
        public Main()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void staffMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerPunchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterPunch registerPunch = new RegisterPunch();
            registerPunch.ShowDialog();
        }

        private void setFingerprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFingerprint frmSetFingerprint = new SetFingerprint();
            frmSetFingerprint.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
