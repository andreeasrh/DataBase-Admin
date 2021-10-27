using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlProcess
{
    public partial class settingsUser : Form
    {
        public settingsUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.host1 = txtHost1.Text;
            Properties.Settings.Default.port1 = txtPort1.Text;
            Properties.Settings.Default.database1 = txtDB1.Text;
            Properties.Settings.Default.user1 = txtUser1.Text;
            Properties.Settings.Default.password1 = txtPassword1.Text;

            Properties.Settings.Default.host2 = txtHost2.Text;
            Properties.Settings.Default.port2 = txtPort2.Text;
            Properties.Settings.Default.database2 = txtDB2.Text;
            Properties.Settings.Default.user2 = txtUser2.Text;
            Properties.Settings.Default.password2 = txtPass2.Text;

            Properties.Settings.Default.host3 = txtHost3.Text;
            Properties.Settings.Default.port3 = txtPort3.Text;
            Properties.Settings.Default.database3 = txtDB3.Text;
            Properties.Settings.Default.user3 = txtUser3.Text;
            Properties.Settings.Default.password3 = txtPass3.Text;

            Properties.Settings.Default.Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.host1 = "";
            Properties.Settings.Default.port1 = "";
            Properties.Settings.Default.database1 = "";
            Properties.Settings.Default.user1 = "";
            Properties.Settings.Default.password1 = "";
            Properties.Settings.Default.Save();
        }

        
    }
}
