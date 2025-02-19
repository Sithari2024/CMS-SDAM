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
    public partial class PlaceToOrder : Form
    {
        private int id;
        private Admin admin;
        private int OrderId;
        public PlaceToOrder()
        {
            InitializeComponent();
            admin = new Admin();
            this.id = Id;
        }

        private void PlaceToOrder_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            int DriverId = Convert.ToInt32(txtDriverID.Text);
            Driver Driver = admin.GetDriver(DriverId);
            Customer customer = admin.GetCustomer(id);
            Order order = new Order(customer, Driver, DateTime.Now, txtPickupLocation.Text, txtDestination.Text);
            order.PlaceOrder(order);

            OrderId = order.nextOrderId;
            textBox6.Text = OrderId.ToString();
            textBox7.Text = order.GetCustomer().GetId.ToString();
            textBox8.Text = order.GetDriver().GetId.ToString();
            textBox9.Text = order.GetDriver().GetCar().GetPlateNumber().ToString();
            if (btnOrderClear_Click != null)
            {
                order.CancelOrder(order);
            }
        }

        private void btnOrderClear_Click(object sender, EventArgs e)
        {
            /*ClearInputs();
            dataGridView1.Rows.Clear();
            MessageBox.Show("Inputs and DataGridView cleared successfully!", "Clearing", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void ClearInputs()
        {
            txtDriverID.Clear();
            txtCarId.Clear();
            txtPickupLocation.Clear();
            txtDestination.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["PlateNumber"].Value.ToString();
                txtDriverID.Text = row.Cells["DriverId"].Value.ToString();
                textBox3.Text = row.Cells["Model"].Value.ToString();
            }
        }
    }
}