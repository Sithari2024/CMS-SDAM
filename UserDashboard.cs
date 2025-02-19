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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CMS_SDAM
{
    public partial class UserDashboard : Form
    {
        private int Id;
        public UserDashboard(int Id)
        {
            this.Id = Id;
            InitializeComponent();
        }

        private void btnAvailableCars_Click(object sender, EventArgs e)
        {
            // Redirect to AvailableCars form
            AvailableCars availableCarsForm = new AvailableCars(Id);
            availableCarsForm.Show();
            this.Close();

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Show a logout message
            MessageBox.Show("Logout successful.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Redirect to Login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
            
            
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(Id);
            editProfile.Show();

        }
    }
}
