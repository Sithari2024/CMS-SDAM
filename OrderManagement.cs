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
        private Admin admin;
        public OrderManagement()
        {
            admin = new Admin();
            InitializeComponent();
            ViewAll();
        }
        public void ViewAll()
        {
            dataGridView1.DataSource = admin.ViewAllOrders();
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
