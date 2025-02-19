using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_SDAM
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

        }
        private void CarMg_Click(object sender, EventArgs e)
        {
            CarManagement carManagementForm = new CarManagement();
            carManagementForm.Show();
        }

        private void DriverMg_Click(object sender, EventArgs e)
        {
            DriverManagement driverManagementForm = new DriverManagement();
            driverManagementForm.Show();

        }

        private void OrderMg_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagementForm = new OrderManagement();
            orderManagementForm.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Show a logout message
            MessageBox.Show("Logout successful.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Redirect to Login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Close all other forms
            List<Form> openForms = Application.OpenForms.OfType<Form>().ToList();
            foreach (Form form in openForms)
            {
                if (form != loginForm)
                {
                    form.Close();
                }
            }
        }
    }
}
