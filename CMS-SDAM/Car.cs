using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class Car
    {

        // Private fields
        private int carId;
        private string? model;
        private int plateNumber;
        private bool availabilityStatus;



        // Constructor to initialize Car object
        public Car(int carId, string model, int plateNumber, bool Available)
        {
            this.carId = carId;
            this.model = model;
            this.plateNumber = plateNumber;
            this.availabilityStatus = Available;



        }

        // Getter methods
        public int GetCarId()
        {
            return carId;
        }

        public string GetModel()
        {
            return model;
        }

        public int GetPlateNumber()
        {
            return plateNumber;
        }

        public bool IsAvailable()
        {
            return availabilityStatus;
        }

        // Method to update availability status
        public void UpdateAvailability(bool newStatus)
        {
            if (availabilityStatus == newStatus)
            {
                Console.WriteLine("Error: The availability status is already set to the provided value.");
                return;
            }

            availabilityStatus = newStatus;
            Console.WriteLine($"Availability status updated successfully: {availabilityStatus}");
        }

        // Implementing the IBookable interface to define booking operations for cars
        public void Book()
        {
            if (!availabilityStatus)
            {
                Console.WriteLine("Error: The car is already booked.");
                return;
            }

            availabilityStatus = false;
            Console.WriteLine($"Car {carId} has been booked.");
        }

        public void CancelBooking()
        {
            if (availabilityStatus)
            {
                Console.WriteLine("Error: The car is not booked.");
                return;
            }

            availabilityStatus = true;
            Console.WriteLine($"Booking for Car {carId} has been canceled.");
        }

        public override string ToString()
        {
            return $"Car ID: {carId}, Model: {model}, Plate Number: {plateNumber}, Available: {availabilityStatus}";
        }
    }
}




