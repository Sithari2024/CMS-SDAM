using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class OrderDetail
    {
        public string DriverID { get; set; }
        public string CarID { get; set; }
        public string PickupLocation { get; set; }
        public string Destination { get; set; }
        public string Date { get; set; }
    }
}
