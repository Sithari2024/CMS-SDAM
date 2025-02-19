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
    public partial class EditProfile : Form
    {
        private int id;
        private Admin admin;

        public EditProfile(int Id)
        {
            admin = new Admin();
            id = Id;
            InitializeComponent();
            ViewAll();
        }

        public void ViewAll()
        {
            Customer customer = admin.GetCustomer(id);
            txtId.Text = customer.GetId.ToString();
            txtName.Text = customer.GetName.ToString();
            txtUserName.Text = customer.GetUserName.ToString();
            txtPassword.Text = customer.GetPassword.ToString();
            txtContactNo.Text = customer.GetcontactNumber.ToString();
            txtIdentity.Text = customer.GetIdentity.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate Contact Number
                if (!int.TryParse(txtContactNo.Text, out int Contact))
                {
                    MessageBox.Show("Please enter a valid Contact number.");
                    return;
                }

                // Validate Name
                string name = txtName.Text;
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter a valid name.");
                    return;
                }

                // Validate Password
                string password = txtPassword.Text;
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter a valid password.");
                    return;
                }

                int Id = Convert.ToInt32(txtId.Text);
                int Identity = Convert.ToInt32(txtIdentity.Text);
                string userName = txtUserName.Text;

                // Create a Customer object
                Customer customer = new Customer(userName, password, name, Id, Identity, Contact);

                // Update the customer profile
                admin.UpdatePerson(customer);

                // Show success message
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter valid data. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
