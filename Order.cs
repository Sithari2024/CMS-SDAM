using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class Order
    {
        private Admin admin;

        public int nextOrderId;
        private Customer Customer { get; set; }
        private Driver Driver { get; set; }
        public string Pickup { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }

        public Order(int Id,Customer customer, Driver driver, DateTime date, string pickup, string destination)
        {
            nextOrderId= Id;    
            admin = new Admin();
            Destination = destination;
            Pickup = pickup;
            Customer = customer;
            Driver = driver;
            Date = date;
        }

        public void PlaceOrder(Order order)
        {
            admin.GetOrders().Clear();
            admin.Loadorder();
            admin.GetOrders().Add(order);
            Driver.UpdateAvailability(false);
            Driver.GetCar().UpdateAvailability(false);
            Carmanageble.UpdateDriver(Driver);
            Carmanageble.UpdateCar(Driver.GetCar());
            Carmanageble.AddOrder(order);
        }

        public Customer GetCustomer()
        {
            return Customer;
        }
        public Driver GetDriver()
        {
            return Driver;
        }


        public void CancelOrder(Order order)
        {
            admin.Loadorder();
            admin.GetOrders().Remove(order);
            Driver.UpdateAvailability(true);
            Driver.GetCar().UpdateAvailability(true);
            Carmanageble.UpdateDriver(Driver);
            Carmanageble.UpdateCar(Driver.GetCar());
            Carmanageble.DeleteOrder(order.nextOrderId);
        }

    }
}
