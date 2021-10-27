using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;


namespace ControlProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();

        }


        public static string host = string.Empty;
        public static string port = string.Empty;
        public static string database = string.Empty;
        public static string user = string.Empty;
        public static string password = string.Empty;



        private void button1_Click(object sender, EventArgs e)
        {
            host = txtHost.Text;
            port = txtPort.Text;
            database = txtDB.Text;
            user = txtUser.Text;
            password = txtPassword.Text;

            string conString = $"host={host};port={port};database={database};user={user};password={password};";

            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand();

            bool connn = false;

            bool okData = false;

            if (host == "" && port == "" && database == "" && user == "" && password == "")
            {
                MessageBox.Show("You need to put your auth data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                okData = false;
            }
            else if (host == "" || port == "" || user == "" || database == "" || password == "")
            {
                MessageBox.Show("You need to put your data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                okData = false;
            }

            okData = true;


            if (okData == true)
            {
                try
                {
                    con.Open();
                    connn = true;
                }
                catch (Exception ex)
                {
                    connn = false;
                }



                Thread.Sleep(2000);
                progressBar1.Show();


                for (int i = 0; i <= 10; i++)
                {
                    progressBar1.PerformStep();
                    Thread.Sleep(100);

                    if (i == 5 && connn == false)
                    {
                        MessageBox.Show("Connection Failed!");
                        i = 10;
                        progressBar1.Value = 0;
                    }

                }

                Thread.Sleep(500);

                if (connn == true)
                {
                    MessageBox.Show("Connection Succesfully!");
                    labelStatus.Text = $"Status: Connected to Database: {database}";
                }


                Thread.Sleep(1000);
                progressBar1.Hide();


                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM `{database}`.`usersdata`;", conString);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dGV1.DataSource = dt;

                    MySqlDataAdapter da2 = new MySqlDataAdapter($"SELECT * FROM `{database}`.`keysgen`;", conString);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);

                    dGV2.DataSource = dt2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Enter the command in the Command Section!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBoxSP.Visible = false;
            txtDB.Text = Properties.Settings.Default.database1;
            txtHost.Text = Properties.Settings.Default.host1;
            txtPassword.Text = Properties.Settings.Default.password1;
            txtPort.Text = Properties.Settings.Default.port1;
            txtUser.Text = Properties.Settings.Default.user1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            host = txtHost.Text;
            port = txtPort.Text;
            database = txtDB.Text;
            user = txtUser.Text;
            password = txtPassword.Text;

            string conString = $"host={host};port={port};database={database};user={user};password={password};";

            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand();

            bool connn = false;

            bool okData = false;

            if (host == "" && port == "" && database == "" && user == "" && password == "")
            {
                MessageBox.Show("You need to put your auth data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                okData = false;
            }
            else if (host == "" || port == "" || user == "" || database == "" || password == "")
            {
                MessageBox.Show("You need to put your data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                okData = false;
            }

            okData = true;


            if (okData == true)
            {
                try
                {
                    con.Open();
                    connn = true;
                }
                catch (Exception ex)
                {
                    connn = false;
                }



                Thread.Sleep(2000);
                progressBar1.Show();


                for (int i = 0; i <= 10; i++)
                {
                    progressBar1.PerformStep();
                    Thread.Sleep(100);

                    if (i == 5 && connn == false)
                    {
                        MessageBox.Show("Connection Failed!");
                        i = 10;
                        progressBar1.Value = 0;
                    }

                }

                Thread.Sleep(500);

                if (connn == true)
                {
                    MessageBox.Show("Succes!");
                    labelStatus.Text = $"Status: Connected to Database: {database}";
                }


                Thread.Sleep(1000);
                progressBar1.Hide();


                MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM `{database}`.`usersdata`;", conString);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dGV1.DataSource = dt;

                try
                {
                    MySqlDataAdapter da2 = new MySqlDataAdapter($"SELECT * FROM `{database}`.`keysgen`;", conString);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);

                    dGV2.DataSource = dt2;
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            host = txtHost.Text;
            port = txtPort.Text;
            database = txtDB.Text;
            user = txtUser.Text;
            password = txtPassword.Text;

            string conString = $"host={host};port={port};database={database};user={user};password={password};";

            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand();

            bool connn = false;

            bool okData = false;

            if (host == "" && port == "" && database == "" && user == "" && password == "")
            {
                MessageBox.Show("You need to put your auth data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                okData = false;
            }
            else if (host == "" || port == "" || user == "" || database == "" || password == "")
            {
                MessageBox.Show("You need to put your data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                okData = false;
            }

            okData = true;


            if (okData == true)
            {
                try
                {
                    con.Open();
                    connn = true;
                }
                catch (Exception ex)
                {
                    connn = false;
                }



                Thread.Sleep(2000);
                progressBar1.Show();


                for (int i = 0; i <= 10; i++)
                {
                    progressBar1.PerformStep();
                    Thread.Sleep(100);

                    if (i == 5 && connn == false)
                    {
                        MessageBox.Show("Connection Failed!");
                        i = 10;
                        progressBar1.Value = 0;
                    }

                }

                Thread.Sleep(500);

                if (connn == true)
                {
                    MessageBox.Show("Succes!");
                    labelStatus.Text = $"Status: Connected to Database: {database}";
                }


                Thread.Sleep(1000);
                progressBar1.Hide();


                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(txtCmd.Text.ToString(), conString);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dGV1.DataSource = dt;
                }
                catch (Exception ex){
                    MessageBox.Show("It's an error in your SQL Command!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnClearCmd_Click(object sender, EventArgs e)
        {
            txtCmd.Text = "";
        }

        private void checkBoxSP_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSP.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new settingsUser().Hide();
            new settingsUser().Show();
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            checkBoxSP.Visible = false;
            txtDB.Text = Properties.Settings.Default.database2;
            txtHost.Text = Properties.Settings.Default.host2;
            txtPassword.Text = Properties.Settings.Default.password2;
            txtPort.Text = Properties.Settings.Default.port2;
            txtUser.Text = Properties.Settings.Default.user2;
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            checkBoxSP.Visible = false;
            txtDB.Text = Properties.Settings.Default.database3;
            txtHost.Text = Properties.Settings.Default.host3;
            txtPassword.Text = Properties.Settings.Default.password3;
            txtPort.Text = Properties.Settings.Default.port3;
            txtUser.Text = Properties.Settings.Default.user3;
        }

        private void clearUser_Click(object sender, EventArgs e)
        {
            checkBoxSP.Visible = true;
            txtDB.Text = "";
            txtHost.Text = "";
            txtPassword.Text = "";
            txtPort.Text = "";
            txtUser.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            host = txtHost.Text;
            port = txtPort.Text;
            database = txtDB.Text;
            user = txtUser.Text;
            password = txtPassword.Text;

            string conString = $"host={host};port={port};database={database};user={user};password={password};";

            MySqlConnection con = new MySqlConnection(conString);

            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///this.Opacity = Properties.Settings.Default.opacityBar;
        }
    }
}
