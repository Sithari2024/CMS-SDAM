using Microsoft.VisualBasic.Logging;
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
    public partial class CreateAccount : Form
    {
        private Admin admin;
        public CreateAccount()
        {
            admin = new Admin();
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Person Custommer = new Customer(txtUserName.Text,txtPass.Text,txtName.Text,admin.CustomerId, Convert.ToInt32(txtContactNo.Text), Convert.ToInt32(txtIdentity.Text));
            admin.AddPerson(Custommer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
