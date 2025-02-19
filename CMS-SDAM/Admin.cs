using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class Admin
    {
        private List<Car> cars;
        private List<Driver> drivers;
        private List<Person> persons;
        private List<Customer> customers;
        private List<Order> orders;
        public int NextCarId;
        public int driverId;
        public int CustomerId;
        public int OrderId;


        // Constructor to initialize Admin object
        public Admin()
        {
            orders = new List<Order>();
            cars = new List<Car>();
            drivers = new List<Driver>();
            persons = new List<Person>();
            customers = new List<Customer>();
            NextCarId = 1;
            driverId = 0;
            CustomerId = 0;
        }
        public void UpdateCar(Car car)
        {
            // Clear and reload data to ensure the latest information is used
            cars.Clear();
            LoadData();

            // Find the car by its ID
            Car existingCar = cars.Find(c => c.GetCarId() == car.GetCarId());
            if (existingCar != null)
            {
                // Get the index of the existing car
                int index = cars.IndexOf(existingCar);

                // Check if the plate number is different and if the new plate number already exists
                if (existingCar.GetPlateNumber() != car.GetPlateNumber() && cars.Any(c => c.GetPlateNumber() == car.GetPlateNumber()))
                {
                    MessageBox.Show("Car with the same Plate number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Update the car in the list
                    cars[index] = car;
                    // Update the car in the external system
                    Carmanageble.UpdateCar(car);
                }
            }
            else
            {
                MessageBox.Show("Car Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Person> GetPerson()
        {
            return persons;
        }
        public List<Order> GetOrders()
        {
            return orders;
        }

        public DataTable ViewAllCars()
        {

            DataTable Dt = Carmanageble.ViewCar();
            return Dt;


        }
        public DataTable ViewAlldrivers()
        {

            DataTable Dt = Carmanageble.ViewDriver();
            return Dt;
        }
        public DataTable ViewAvailableCar()
        {
            DataTable Dt = Carmanageble.ViewAvailableCar();
            return Dt;
        }
        public Car GetCar(int id)
        {
            // Load the data from the data source
            LoadData();

            // Find the driver whose car has the specified ID
            Driver driver = drivers.Find(d => d.GetCar().GetCarId() == id);

            // If a driver is found, create a new car object with the driver's car data
            if (driver != null)
            {
                return new Car(
                    driver.GetCar().GetCarId(),
                    driver.GetCar().GetModel(),
                    driver.GetCar().GetPlateNumber(),
                    driver.GetCar().IsAvailable()
                );
            }
            else
            {
                // If no driver is found, return null
                return null;
            }
        }
        public Driver GetDriver(int Id)
        {
            drivers.Clear();
            LoadData();
            Driver driver = drivers.Find(c => c.GetId == Id);
            if (driver == null)
            {
                MessageBox.Show("Driver Not Found");
            }
            else
            {
                return driver;
            }
            return null;
        }
        public Customer GetCustomer(int Id)
        {
            customers.Clear();
            LoadData();
            Customer customer = customers.Find(c => c.GetId == Id);
            if (customer == null)
            {
                MessageBox.Show("Customer Not Found");
            }
            else
            {
                return customer;
            }
            return null;
        }
        public Order Order(Customer customer)
        {
            orders.Clear();
            Loadorder();
            if (orders.Any(o => o.GetCustomer().GetId == customer.GetId))
            {
                int order = orders.FindIndex(o => o.GetCustomer().GetId == customer.GetId);
                Order order1 = orders[order];
                return order1;
            }
            return null;
        }
        public void LoadData()
        {
            string query = "SELECT d.Id, d.Identity, d.Name, d.UserName, d.Password, d.ContactNumber, d.IsAvailable, c.CarId, c.Model, c.PlateNumber, c.Available " +
                           "FROM Drivers d INNER JOIN Cars c ON d.Id = c.DriverId";
            Dbmanagement db = new Dbmanagement();
            DataTable dataTable = db.ExecuteQuery(query);

            // Clear existing data in the lists
            drivers.Clear();
            persons.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                // Extract car data
                int carId = Convert.ToInt32(row["CarId"]);
                string model = row["Model"].ToString();
                int plateNumber = Convert.ToInt32(row["PlateNumber"]);
                bool carAvailable = Convert.ToBoolean(row["Available"]);
                Car car = new Car(carId, model, plateNumber, carAvailable);

                // Update the next car ID
                NextCarId = carId + 1;

                // Extract driver data
                int driverId = Convert.ToInt32(row["Id"]);
                int identity = Convert.ToInt32(row["Identity"]);
                string name = row["Name"].ToString();
                string userName = row["UserName"].ToString();
                string password = row["Password"].ToString();
                int contactNumber = Convert.ToInt32(row["ContactNumber"]);
                bool driverAvailable = Convert.ToBoolean(row["IsAvailable"]);
                Driver driver = new Driver(userName, password, name, driverId, identity, contactNumber, driverAvailable, car);

                // Add the driver to the lists
                drivers.Add(driver);
                persons.Add(driver);

                // Update the next driver ID
                this.driverId = driverId + 1;
            }
        }
        public void Loadorder()
        {
            Dbmanagement db = new Dbmanagement();
            string query2 = " SELECT  o.Destination,o.PickUp,d.Id AS DriverId,c.Id AS CustomerId,o.Date,o.Id FROM Orders o JOIN Customers c ON o.CustomerId = c.Id JOIN Drivers d ON o.DriverId = d.Id";
            DataTable dataTable2 = db.ExecuteQuery(query2);

            foreach (DataRow row in dataTable2.Rows)
            {

                int ID = Convert.ToInt32(row["Id"]);
                string? Destination = row["Destination"].ToString();
                string? PickUp = row["PickUp"].ToString();
                int DriverId = Convert.ToInt32(row["DriverId"]);
                int CustomerId = Convert.ToInt32(row["CustomerId"]);
                DateTime date = Convert.ToDateTime(row["Date"].ToString());
                Driver driver = GetDriver(DriverId);
                Customer customer = GetCustomer(CustomerId);
                OrderId = ID + 1;
                orders.Add(new Order(ID, customer, driver, PickUp, Destination, date));


            }
        }


        public void AddPerson(Person person)
        {
            if (person is Driver driver)
            {
                // Check if driver already exists
                bool driverExists = drivers.Any(d => d.GetIdentity == driver.GetIdentity);
                bool usernameTaken = drivers.Any(d => d.GetUserName == driver.GetUserName);
                bool carExists = drivers.Any(d => d.GetCar().GetPlateNumber() == driver.GetCar().GetPlateNumber());

                // Display error messages if necessary
                if (driverExists)
                {
                    MessageBox.Show("Driver already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (usernameTaken)
                {
                    MessageBox.Show("Username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (carExists)
                {
                    MessageBox.Show("Car with the same Platenumber already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Add driver and associated car
                    persons.Add(driver);
                    drivers.Add(driver);
                    Carmanageble.AddCar(driver.GetCar(), driver);
                }
            }
            else if (person is Customer customer)
            {
                // Add customer
                persons.Add(customer);
                customers.Add(customer);
            }
        }

        public void RemovePersonById(int Id)
        {
            persons.Clear();
            drivers.Clear();
            LoadData();

            int index = -1;
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].GetId == Id)
                {
                    index = i;
                    break;
                }
            }

            if (index >= 0)
            {
                Person person = persons[index];
                persons.RemoveAt(index);

                if (person is Driver)
                {
                    int driverIndex = drivers.FindIndex(d => d.GetId == person.GetId);
                    if (driverIndex >= 0)
                    {
                        drivers.RemoveAt(driverIndex);
                        Carmanageble.RemoveDriver((Driver)person);
                    }
                }
                else if (person is Customer)
                {
                    int customerIndex = customers.FindIndex(c => c.GetId == person.GetId);
                    if (customerIndex >= 0)
                    {
                        customers.RemoveAt(customerIndex);
                        Carmanageble.RemoveCustomer(Id);
                    }
                }
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
        public void UpdatePerson(Person person)
        {
            // Clear and reload data to ensure the latest information
            persons.Clear();
            drivers.Clear();
            customers.Clear();
            LoadData();

            // Find the existing person by ID
            Person existingPerson = persons.Find(p => p.GetId == person.GetId);
            if (existingPerson == null)
            {
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the index of the existing person in the list
            int personIndex = persons.FindIndex(p => p.GetId == person.GetId);

            // Update logic for Driver
            if (person is Driver driver)
            {
                int driverIndex = drivers.FindIndex(d => d.GetId == driver.GetId);
                bool userNameExists = drivers.Any(d => d.GetUserName == driver.GetUserName && d.GetId != driver.GetId);
                bool plateNumberExists = drivers.Any(d => d.GetCar().GetPlateNumber() == driver.GetCar().GetPlateNumber() && d.GetId != driver.GetId);
                bool identityExists = drivers.Any(d => d.GetIdentity == driver.GetIdentity && d.GetId != driver.GetId);

                if (identityExists)
                {
                    MessageBox.Show("Driver with the same ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (userNameExists)
                {
                    MessageBox.Show("Username is taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (plateNumberExists)
                {
                    MessageBox.Show("Car with the same Plate number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Update the driver and car in the list
                    persons[personIndex] = person;
                    drivers[driverIndex] = driver;
                    Carmanageble.UpdateCar(driver.GetCar());
                    Carmanageble.UpdateDriver(driver);
                }
            }
            // Update logic for Customer
            else if (person is Customer customer)
            {
                int customerIndex = customers.FindIndex(c => c.GetId == customer.GetId);
                bool userNameExists = customers.Any(c => c.GetUserName == customer.GetUserName && c.GetId != customer.GetId);
                bool identityExists = customers.Any(c => c.GetIdentity == customer.GetIdentity && c.GetId != customer.GetId);

                if (identityExists)
                {
                    MessageBox.Show("Customer with the same ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (userNameExists)
                {
                    MessageBox.Show("Username is taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Update the customer in the list
                    persons[personIndex] = person;
                    customers[customerIndex] = customer;
                    Carmanageble.UpdateCustomer(customer);
                }
            }
        }

        public List<Driver> GetAvailableDrivers()
        {

            return drivers.Where(d => d.IsAvailable()).ToList();

        }
    }
}









// Methods to manage cars
/* public void AddCar(Car car)
 {
     LoadData();

     if (cars.Any(c => c.GetPlateNumber() == car.GetPlateNumber()))
     {
         MessageBox.Show("Car with the same Plate number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
     }
     else
     {
         cars.Add(car);
         Cabmanageble.AddCar(car);
     }
 }

 public void RemoveCar(int PlateNumber)
 {
     LoadData();

     Car existingCar = cars.Find(c => c.GetPlateNumber() == PlateNumber);
     if (existingCar != null)
     {
         cars.Remove(existingCar);
         Cabmanageble.DeleteCar(PlateNumber);
     }
     else
     {
         MessageBox.Show("Car with the provided Plate Number is not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
     }
 }

 public void UpdateCar(Car car)
 {
     LoadData();

     Car existingCar = cars.FirstOrDefault(c => c.GetCarId() == car.GetCarId());

     if (existingCar != null)
     {
         int index = cars.IndexOf(existingCar);

         if (existingCar.GetPlateNumber() == car.GetPlateNumber() || !cars.Any(c => c.GetPlateNumber() == car.GetPlateNumber()))
         {
             cars[index] = car;
             Cabmanageble.UpdateCar(car);
         }
         else
         {
             MessageBox.Show("Another car with the same Plate Number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
     }
     else
     {
         MessageBox.Show("Car not found for updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
     }
 }

 public DataTable ViewAllCars()
 {
     return Cabmanageble.Viewcar();
 }

 public List<CarDetails> GetCarDetails()
 {
     return cars.Select(car => new CarDetails
     {
         CarId = car.GetCarId(),
         Model = car.GetModel(),
         PlateNumber = car.GetPlateNumber(),
         IsAvailable = car.IsAvailable()
     }).ToList();
 }

 public DataTable ViewAlldrivers()
 {
     return Cabmanageble.ViewDriver();
 }

 public void LoadData()
 {
     string query = "SELECT * FROM cars";
     Dbmanagement db = new Dbmanagement();
     DataTable dataTable = db.ExecuteQuery(query);


     foreach (DataRow row in dataTable.Rows)
     {
         int carId = Convert.ToInt32(row["carId"]);
         string? model = row["Model"].ToString();
         int PlateNumber = Convert.ToInt32(row["PlateNumber"]);
         bool IsAvailable = Convert.ToBoolean(row["IsAvailable"]);
         cars.Add(new Car(carId, model, PlateNumber, IsAvailable));
         NextCarId = carId + 1;
     }
     LoadDataAll.LoadDataDriver(drivers);

 }

 public void AddPerson(Person person)
 {
     if (person is Driver driver)
     {
         if (drivers.Any(c => c.GetId == driver.GetId) || drivers.Any(c => c.username() == driver.username()))
         {
             MessageBox.Show("Driver already exists in the system or username is already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         else
         {
             drivers.Add(driver);
             Cabmanageble.AddDriver(driver);
             persons.Add(person);
         }
     }
     else if (person is Customer customer)
     {
         customers.Add(customer);
         persons.Add(person);
     }
     else
     {
         persons.Add(person);
     }
 }
}
}









 // Methods to manage drivers
/* public void AddDriver(int driverId, string name, int contactNumber, bool availabilityStatus)
 {
     if (drivers.Any(d => d.Id == driverId))
     {
         throw new ArgumentException("Driver with the same ID already exists.");
     }

     Driver newDriver = new Driver(driverId, name, contactNumber, availabilityStatus);
     drivers.Add(newDriver);
 }

 public void RemoveDriver(Driver driver)
 {
     // Check if the driver object is null
     if (driver == null)
     {
         throw new ArgumentNullException(nameof(driver), "Driver object cannot be null.");
     }

     // Remove the driver from the list
     drivers.Remove(driver);
 }

 // Method to view all drivers
 public void ViewAllDrivers()
 {
     if (drivers.Count == 0)
     {
         Console.WriteLine("No drivers available.");
         return;
     }

     Console.WriteLine("All Drivers:");
     foreach (Driver driver in drivers)
     {
         Console.WriteLine(driver.GetDetails());
     }
 }

 // Method to view all orders
 public void ViewAllOrders()
 {
     if (orders.Count == 0)
     {
         Console.WriteLine("No orders available.");
         return;
     }

     Console.WriteLine("All Orders:");
     foreach (Order order in orders)
     {
         Console.WriteLine($"Order ID: {order.OrderId}, Customer: {order.Customer.Name}, Driver: {order.Driver.Name}, Date: {order.Date}");
     }
 }

 // Method to place an order
 public void PlaceOrder(Customer customer, Driver driver, Car car, DateTime date)
 {
     try
     {
         if (customer == null || driver == null || car == null)
         {
             throw new ArgumentNullException("Customer, driver, or car object cannot be null.");
         }

         if (!car.IsAvailable() || !driver.IsAvailable())
         {
             throw new InvalidOperationException("Cannot place order: Car or driver is not available.");
         }

         // Create a new Order object
         Order newOrder = new Order(GenerateOrderId(), customer, driver, car, date);

         // Add the order to the list of orders
         orders.Add(newOrder);

         // Update the availability of the assigned driver and car
         driver.UpdateAvailability(false);
         car.UpdateAvailability(false);

         Console.WriteLine("Order placed successfully!");
     }
     catch (ArgumentNullException ex)
     {
         Console.WriteLine(ex.Message);
     }
     catch (InvalidOperationException ex)
     {
         Console.WriteLine(ex.Message);
     }
 }

 // Method to generate a unique order ID
 private int GenerateOrderId()
 {
     return orders.Count + 1;
 }
}
}*/
