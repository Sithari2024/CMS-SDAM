using CMS_SDAM;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMS_SDAM
{
    public partial class DriverManagement : Form
    {
        private Admin admin;

        public DriverManagement()
        {
            admin = new Admin();
            admin.LoadData();
            InitializeComponent();
            ViewAll();
        }
        public void ViewAll()
        {
            dataGridView1.DataSource = admin.ViewAlldrivers();

        }

        private void DriverManagement_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                PopulateDriverDetails(row);
            }
        }

        private void PopulateDriverDetails(DataGridViewRow row)
        {
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtUserName.Text = row.Cells["UserName"].Value.ToString();
            txtPassword.Text = row.Cells["Password"].Value.ToString();
            txtIdentity.Text = row.Cells["Identity"].Value.ToString();
            txtContactNumber.Text = row.Cells["ContactNumber"].Value.ToString();
            txtId.Text = row.Cells["Id"].Value.ToString();
            txtPlateNumber.Text = row.Cells["CarId"].Value.ToString();
            chkAvailability.Checked = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
        }
        private void BtnRemoveDriver_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                admin.RemovePersonById(id);
                ViewAll();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please select a driver to remove.");
            }
        }
        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            string model = txtModel.Text;
            int plateNumber = Convert.ToInt32(txtPlateNumber.Text);
            int identity = Convert.ToInt32(txtIdentity.Text);
            string name = txtName.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            int contactNumber = Convert.ToInt32(txtContactNumber.Text);

            Person driver = new Driver(userName, password, name, admin.driverId, identity, contactNumber, true, new Car(admin.NextCarId, model, plateNumber, true));

            admin.AddPerson(driver);
            ViewAll();
            ClearInputFields();
        }



        // Method to clear input fields
        private void ClearInputFields()
        {
            txtName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtContactNumber.Text = "";
            txtId.Text = "";
            txtPlateNumber.Text = "";
            chkAvailability.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a driver to update.");
                return;
            }

            int carId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CarId"].Value);
            bool availability = chkAvailability.Checked;

            Person driver = new Driver(txtUserName.Text, txtPassword.Text, txtName.Text, Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdentity.Text), Convert.ToInt32(txtContactNumber.Text), availability, admin.GetCar(carId));

            admin.UpdatePerson(driver);
            ViewAll();
        }
    }
}




