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
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void btnAvailableCars_Click(object sender, EventArgs e)
        {
            // Redirect to AvailableCars form
            /*AvailableCars availableCarsForm = new AvailableCars();
            availableCarsForm.Show();
            */
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {// Show a logout message
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

        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaceToOrder_Click_1(object sender, EventArgs e)
        {
            OrderSummary orderSummaryForm = new OrderSummary(orderDetails);
            orderSummaryForm.Show();

        }
    }
}
