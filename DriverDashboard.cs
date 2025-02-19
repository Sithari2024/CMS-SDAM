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

    public partial class DriverDashboard : Form
    {
        private Admin admin;
        public DriverDashboard()
        {
            admin = new Admin();
            InitializeComponent();
            LoadData();
            ViewALL();
        }
        public void ViewALL()
        {
            Driver driver = admin.GetDriver(UserManager.DriverId);
            bool available = driver.IsAvailable();
            if (available == true)
            {
                checkBox1.Checked = true;
            }

        }

        private void DriverDashboard_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            admin.LoadData();
            Driver driver = admin.GetDriver(UserManager.DriverId);
            Order order1 = admin.ViewOrders(driver);
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable
            dataTable.Columns.Add("Order ID");
            dataTable.Columns.Add("Destination");
            dataTable.Columns.Add("Pickup");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Contact Number");

            if (order1 != null)
            {
                // Add data row
                DataRow row = dataTable.NewRow();
                row["Order ID"] = admin.OrderId.ToString();
                row["Destination"] = order1.Destination.ToString();
                row["Pickup"] = order1.Pickup.ToString();
                row["Date"] = order1.Date.ToString();
                row["Contact Number"] = order1.GetCustomer().GetcontactNumber.ToString();
                dataTable.Rows.Add(row);
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Driver driver = admin.GetDriver(UserManager.DriverId);
                driver.UpdateAvailability(true);
                driver.GetCar().UpdateAvailability(true);
                admin.UpdatePerson(driver);
            }
            else
            {
                Driver driver = admin.GetDriver(UserManager.DriverId);
                driver.UpdateAvailability(false);
                driver.GetCar().UpdateAvailability(false);
                admin.UpdatePerson(driver);

            }
        }
    }
}
