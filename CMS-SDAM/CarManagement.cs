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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CMS_SDAM
{
    public partial class CarManagement : Form
    {
        private Admin admin;

        public CarManagement()
        {
            admin = new Admin();
            admin.LoadData();
            InitializeComponent();
            ViewAll();
        }
        public void ViewAll()
        {
            dataGridView1.DataSource = admin.ViewAllCars();
        }
        private void CarManagement_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                PopulateCarDetails(row);
            }
        }

        private void PopulateCarDetails(DataGridViewRow row)
        {
            txtCarId.Text = row.Cells["CarId"].Value.ToString();
            txtModel.Text = row.Cells["Model"].Value.ToString();
            txtPlateNumber.Text = row.Cells["PlateNumber"].Value.ToString();
            txtDriverId.Text = row.Cells["DriverId"].Value.ToString();
            chkAvailable.Checked = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
        }


        private void AddCar_Click(object sender, EventArgs e)
        {
            /*try
            {
                string model = txtModel.Text;
                int plateNumber = Convert.ToInt32(txtPlateNumber.Text);
                Car car = new Car(admin.NextCarId, model, plateNumber, true);
                admin.AddCar(car);
                ViewAll();
                ClearInputFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid plate number.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }*/
        }

        private void RemoveCar_Click(object sender, EventArgs e)
        {
            {
                if (txtDriverId.Text == ("") && dataGridView1.SelectedRows.Count > 0)
                {
                    int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DriverId"].Value);
                    admin.RemovePersonById(Id);
                    ViewAll();

                }
                else
                {
                    int Id = Convert.ToInt32(txtDriverId.Text);
                    admin.RemovePersonById(Id);
                    ViewAll();
                }

            }
            // Clear input fields
            ClearInputFields();
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
                MessageBox.Show("Please select a car to update.");
                return;
            }

            int carId = Convert.ToInt32(txtCarId.Text);
            string model = txtModel.Text;
            int plateNumber = Convert.ToInt32(txtPlateNumber.Text);
            bool availability = chkAvailable.Checked;

            Car car = new Car(carId, model, plateNumber, availability);
            admin.UpdateCar(car);
            ViewAll();
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            txtCarId.Text = "";
            txtModel.Text = "";
            txtPlateNumber.Text = "";
            txtDriverId.Text = "";
            chkAvailable.Checked = false;
        }
    }
}
