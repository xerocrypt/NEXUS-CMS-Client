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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            frmConnect myAuthentication = new frmConnect();
            myAuthentication.Show();
        }

        private void cmdCases_Click(object sender, EventArgs e)
        {
            string loadSet = "datasource=" + AuthenticationSettings.Settings.serverIP + ";port=3306;username=" + AuthenticationSettings.Settings.loginName + ";password=" + AuthenticationSettings.Settings.authKey + ";";
            try
            {
                MySqlConnection mySession = new MySqlConnection(loadSet);
                MySqlCommand dbCommand = new MySqlCommand(" select * from nexus.cases ; ", mySession);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = dbCommand;
                DataTable tutorial = new DataTable();
                sda.Fill(tutorial);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = tutorial;
                dataGrid.DataSource = bsource;
                sda.Update(tutorial);

                txtStatus.Text = "Connected to database server";
            }

            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();
            }



            // Load database connection for the charts
            try
            {
                string loadSet2 = "datasource=" + AuthenticationSettings.Settings.serverIP + ";port=3306;username=" + AuthenticationSettings.Settings.loginName + ";password=" + AuthenticationSettings.Settings.authKey + ";";
                MySqlConnection mySession2 = new MySqlConnection(loadSet);
                MySqlCommand dbCommand2 = new MySqlCommand(" select * from nexus.cases ; ", mySession2);

                MySqlDataReader myReader;

                mySession2.Open();
                myReader = dbCommand2.ExecuteReader();

                while (myReader.Read())
                {
                    this.crtMalwareTypes.Series["CaseNumber"].Points.AddXY(myReader.GetString("MalwareUsed"), myReader.GetInt32("CaseNumber"));
                    this.crtMalwareTypes2.Series["CaseNumber"].Points.AddXY(myReader.GetString("MalwareUsed"), myReader.GetInt32("CaseNumber"));
                }
            }

            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();
            }

        }

        private void cmdAddCase_Click(object sender, EventArgs e)
        {
            frmAddCase myNewCase = new frmAddCase();
            myNewCase.Show();
        }

        private void cmdAddMalware_Click(object sender, EventArgs e)
        {
            frmAddMalware myNewMalware = new frmAddMalware();
            myNewMalware.Show();
        }

        private void cmdMalware_Click(object sender, EventArgs e)
        {
            string loadSet = "datasource=" + AuthenticationSettings.Settings.serverIP + ";port=3306;username=" + AuthenticationSettings.Settings.loginName + ";password=" + AuthenticationSettings.Settings.authKey + ";";
            try
            {
                MySqlConnection mySession = new MySqlConnection(loadSet);
                MySqlCommand dbCommand = new MySqlCommand(" select * from nexus.malware ; ", mySession);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = dbCommand;
                DataTable tutorial = new DataTable();
                sda.Fill(tutorial);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = tutorial;
                dataGrid.DataSource = bsource;
                sda.Update(tutorial);

                txtStatus.Text = "Connected to database server";
            }

            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();
            }
        }

        private void crtMalwareTypes_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmClient_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateMalwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMalware myNewMalware = new frmAddMalware();
            myNewMalware.Show();
        }

        private void updateCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCase myNewCase = new frmAddCase();
            myNewCase.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout showInfo = new frmAbout();
            showInfo.Show();
        }
    }
}
