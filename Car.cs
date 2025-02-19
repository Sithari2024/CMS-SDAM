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
            availabilityStatus = newStatus;
        }

    }
}




