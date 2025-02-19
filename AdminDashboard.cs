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
            this.Close();
        }

        private void DriverMg_Click(object sender, EventArgs e)
        {
            DriverManagement driverManagementForm = new DriverManagement();
            driverManagementForm.Show();
            this.Close();

        }

        private void OrderMg_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagementForm = new OrderManagement();
            orderManagementForm.Show();
            this.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout successful.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewCustomer viewCustomer = new ViewCustomer();
            viewCustomer.Show();
            this.Close();

        }
    }
}
