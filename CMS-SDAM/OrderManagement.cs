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

namespace CMS_SDAM
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            try
            {
                using (MySqlConnection conn = DbConnector.GetConnection())
                {
                    conn.Open();
                    DataTable orderTable = OrderDataAccess.GetAllOrders(conn);
                    dataGridView1.DataSource = orderTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading order data: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();

        }
    }
}
