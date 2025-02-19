using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class Driver : Person
    {

        private bool Availability { get; set; }
        private Car Car { get; set; }


        public Driver(string Username, string Password, string name, int Id, int Identity, int ContactNumber, bool Availability, Car car) : base(Username, Password, name, Id, Identity, ContactNumber)
        {

            this.Availability = Availability;
            this.Car = Car;

        }


        // Method to check availability status
        public bool IsAvailable()
        {
            return Availability;
        }
        public void UpdateAvailability(bool newStatus)
        {
            Availability = newStatus;
        }
        public Car GetCar()
        {
            return Car;
        }
        // Method to update availability status


        // Overridden method to get driver details
        public override void GetDetails()
        {
            int id = Convert.ToInt32(GetId);
            int Identity = Convert.ToInt32(GetIdentity);
            int ContactNummber = Convert.ToInt32(GetcontactNumber);
            string Name = GetName.ToString();
            string UserName = GetUserName.ToString();
            string Password = GetPassword.ToString();

        }
    }
}
