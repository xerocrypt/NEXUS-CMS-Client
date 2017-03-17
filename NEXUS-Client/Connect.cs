using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NEXUS_Client
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void Connect_Load(object sender, EventArgs e)
        {

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            AuthenticationSettings.Settings.serverIP = txtServerAddress.Text;
            AuthenticationSettings.Settings.loginName = txtUserName.Text;
            AuthenticationSettings.Settings.authKey = txtPassword.Text;

            this.Close();
        }
    }
}
