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
    public partial class ViewCustomer : Form
    {
        private Admin admin;
        public ViewCustomer()
        {
            admin = new Admin();
            InitializeComponent();
            ViewAll();
        }
        public void ViewAll()
        {
            dataGridView1.DataSource = admin.ViewAllCustomers();
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
