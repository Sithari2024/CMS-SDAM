using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class Customer : Person
    {
        public Customer(string UserName, string Password, string name, int ID, int Identity, int ContactNumber) : base(UserName, Password, name, ID, Identity, ContactNumber)

        {

        }
        public override void GetDetails()
        {
            int id = Convert.ToInt32(GetId);
            int ContactNummber = Convert.ToInt32(GetcontactNumber);
            string Name = GetName.ToString();
            int Identity = Convert.ToInt32(GetIdentity);
            string UserName = GetUserName.ToString();
            string Password = GetPassword.ToString();
        }
        // Fields
        /*private string currentLocation;
        private string destination;
        private List<Order> orders;
        private static int nextOrderId = 1;

        // Constructor
        public Customer(int id, string name, int contactNumber, string currentLocation, string destination)
            : base(id, name, contactNumber)
        {
            this.currentLocation = currentLocation;
            this.destination = destination;
            orders = new List<Order>();
        }

        // Properties for current location and destination
        public string CurrentLocation
        {
            get { return currentLocation; }
        }

        public string Destination
        {
            get { return destination; }
        }

        // Method to place an order
        public void PlaceOrder(Car car, Driver driver, DateTime date)
        {
            if (!car.IsAvailable())
            {
                Console.WriteLine("Error: The selected car is not available.");
                return;
            }

            if (!driver.IsAvailable())
            {
                Console.WriteLine("Error: The selected driver is not available.");
                return;
            }

            Order order = new Order(nextOrderId++, this, driver, car, date);
            orders.Add(order);
            car.UpdateAvailability(false);
            driver.UpdateAvailability(false);

            Console.WriteLine($"Order placed successfully. Order ID: {order.OrderId}");
        }

        // Overridden method to get customer details
        public override string GetDetails()
        {
            return $"Customer ID: {Id}, Name: {Name}, Contact Number: {ContactNumber}, Current Location: {CurrentLocation}, Destination: {Destination}";
        }

        // Override ToString method
        public override string ToString()
        {
            return GetDetails();
        }*/
    }
}

