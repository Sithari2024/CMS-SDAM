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
    public partial class OrderSummary : Form
    {

        private List<OrderDetail> orderDetails;

        internal OrderSummary(List<OrderDetail> orderDetails)
        {
            InitializeComponent();
            this.orderDetails = orderDetails;
        }

        private void PopulateDataGridView()
        {
            foreach (OrderDetail detail in orderDetails)
            {
                dataGridView1.Rows.Add(detail.DriverID, detail.CarID, detail.Date, detail.PickupLocation, detail.Destination);
            }
        }

        private void OrderSummary_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
       
    }
}
