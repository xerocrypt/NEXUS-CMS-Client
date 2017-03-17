using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NEXUS_Client
{
    public partial class frmAddCase : Form
    {
        public frmAddCase()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                string loadSet = "datasource=" + AuthenticationSettings.Settings.serverIP + ";port=3306;username=" + AuthenticationSettings.Settings.loginName + ";password=" + AuthenticationSettings.Settings.authKey + ";";

                string Query = "insert into nexus.cases (CaseNumber, Title, EntryDate, Description, Target, Source, MalwareUsed, CaseNotes, Reference) values('" + this.txtCaseNum.Text + "', '" + this.txtCaseTitle.Text + "', '" + this.txtEntryDate.Text + "', '" + this.txtDescription.Text + "', '" + this.txtTarget.Text + "', '" + this.txtSource.Text + "', '" + this.txtMalware.Text + "', '" + this.txtNotes.Text + "', '" + this.txtReference.Text + "') ;";
                MySqlConnection conDataBase = new MySqlConnection(loadSet);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Record Added");
                while (myReader.Read())
                {
                }
            }

            // Exception handling for MySQL server connection
            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCase_Load(object sender, EventArgs e)
        {

        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string loadSet = "datasource=" + AuthenticationSettings.Settings.serverIP + ";port=3306;username=" + AuthenticationSettings.Settings.loginName + ";password=" + AuthenticationSettings.Settings.authKey + ";";

                string Query = "update nexus.cases set CaseNumber='" + this.txtCaseNum.Text + "',Title='" + this.txtCaseTitle.Text + "',EntryDate='" + this.txtEntryDate.Text + "',Description='" + this.txtDescription.Text + "',Target='" + this.txtTarget.Text + "', Source='" + this.txtSource.Text + "',MalwareUsed='" + this.txtMalware.Text + "',CaseNotes='" + this.txtNotes.Text + "', Reference='" + this.txtReference.Text + "' where CaseNumber='" + this.txtCaseNum.Text + "';";
                MySqlConnection conDataBase = new MySqlConnection(loadSet);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Record Added");
                while (myReader.Read())
                {
                }
            }

            // Exception handling for MySQL server connection
            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();
            }
        }
    }
}
