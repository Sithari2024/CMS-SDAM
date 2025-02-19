using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class Order
    {
        public int nextOrderId { get; set; }
        private Customer Customer { get; set; }
        private Driver Driver { get; set; }
        public string Pickup { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }

        private List<Order> orders;

        public Order() { }
        public Order(Customer customer, Driver driver, DateTime date, string Pickup, string Destination)
        {
            this.Destination = Destination;
            this.Pickup = Pickup;
            this.nextOrderId = orders.Count;
            Customer = customer;
            Driver = driver;
            Date = date;
            orders = new List<Order>();
        }
        public void PlaceOrder(Order order)
        {

            orders.Clear();
            orders.Add(order);
            Driver.UpdateAvailability(false);
        }
        public Customer GetCustomer()
        {
            return Customer;
        }
        public Driver GetDriver()
        {
            return Driver;
        }
        public List<Order> GetOrders()
        {
            return orders;
        }
        public Order ViewOrder(Driver driver)
        {
            Order order = orders.FirstOrDefault(o => o.Driver.GetId == driver.GetId);

            if (order != null)
            {
                MessageBox.Show("You have an Order ", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new Order(order.Customer, order.Driver, order.Date, order.Pickup, order.Destination);
            }
            else
            {
                return null;
            }
        }
        public void CancelOrder(Order order)
        {
            orders.Remove(order);
            Driver.UpdateAvailability(true);
            ViewOrder(Driver);
        }

        /*public static void PlaceOrder(Customer customer, Driver driver)
        {/*

            Order order = new Order(nextOrderId++, customer, driver, DateTime.Now);
            orders.Add(order);
            driver.UpdateAvailability(false);*/
        }
        /*public Customer GetCustomer()
        {
            return Customer;
        }
        public Driver GetDriver()
        {
            return Driver;
        }
        public List<Order> GetOrders()
        {
            return orders;
        }*/
    }

