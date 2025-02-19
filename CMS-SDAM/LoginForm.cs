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
            admin.GetPerson().Clear();
            admin.LoadData();
            Form user = UserManager.Login(admin.GetPerson(), txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                this.Hide();
                user.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount form = new CreateAccount();
            form.Show();

        }
    }
}


