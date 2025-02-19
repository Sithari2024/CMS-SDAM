using Mysqlx.Crud;
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
    public partial class AvailableCars : Form
    {
        private Admin admin;
        public int id;

        public AvailableCars(int Id)
        {
            admin = new Admin();
            this.id = Id;
            InitializeComponent();
            LoadAll();
            admin.Loadorder();
            admin.LoadData();


        }
        public void LoadAll()
        {
            admin.LoadData();
            admin.Loadorder();
            dataGridView1.DataSource = admin.ViewAvailableCar();
            Customer customer = admin.GetCustomer(id);
            Order order = admin.CheckOrder(customer);
            if (order != null)
            {
                textBox6.Text = order.nextOrderId.ToString();
                textBox7.Text = order.GetCustomer().GetId.ToString();
                textBox8.Text = order.GetDriver().GetId.ToString();
                textBox9.Text = order.GetDriver().GetCar().GetPlateNumber().ToString();
            }
        }
        private void AvailableCars_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["PlateNumber"].Value.ToString();
                textBox2.Text = row.Cells["DriverId"].Value.ToString();
                textBox3.Text = row.Cells["CarId"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DriverId = Convert.ToInt32(textBox2.Text);
            Driver Driver = admin.GetDriver(DriverId);
            Customer customer = admin.GetCustomer(id);
            Order order = new Order(admin.OrderId, customer, Driver, DateTime.Now, textBox4.Text, textBox5.Text);
            Order order1 = admin.CheckOrder(customer);
            if (order1 != null)
            {
                MessageBox.Show("Order is already Placed! Cancel the order to book a new order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                order.PlaceOrder(order);
                LoadAll();
                int OrderId = order.nextOrderId;
                textBox6.Text = OrderId.ToString();
                textBox7.Text = order.GetCustomer().GetId.ToString();
                textBox8.Text = order.GetDriver().GetId.ToString();
                textBox9.Text = order.GetDriver().GetCar().GetPlateNumber().ToString();
            }

            LoadAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = admin.GetCustomer(id);
            Order order = admin.Order(customer);
            order.CancelOrder(order);
            textBox6.Text = ("");
            textBox7.Text = ("");
            textBox8.Text = ("");
            textBox9.Text = ("");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserDashboard user = new UserDashboard(id);
            user.Show();
            this.Close();
        }
    }
}
