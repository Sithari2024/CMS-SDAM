using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMS_SDAM
{
    public partial class LoginForm : Form
    {
        private Admin admin;
        public LoginForm()
        {
            admin = new Admin();
            admin.LoadData();
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Clear existing persons and reload data
            admin.GetPerson().Clear();
            admin.LoadData();

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Attempt login using UserManager
            Form form = UserManager.Login(admin.GetPerson(), username, password);
            if (form != null)
            {
                // Show success message
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                form.Show();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount form = new CreateAccount();
            form.Show();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}


