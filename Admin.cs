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
            OrderId = 0;
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

            DataTable Dt = Carmanageble.Viewcar();
            return Dt;


        }
        public DataTable ViewAlldrivers()
        {

            DataTable Dt = Carmanageble.ViewDriver();
            return Dt;
        }
        public DataTable ViewAllCustomers()
        {
            DataTable Dt = Carmanageble.ViewCustomer();
            return Dt;
        }
        public DataTable ViewAllOrders()
        {
            DataTable Dt = Carmanageble.Vieworders();
            return Dt;
        }
        public DataTable ViewAvailableCar()
        {
            DataTable Dt = Carmanageble.ViewAvailableCar();
            return Dt;
        }
        public Order ViewOrders(Driver driver)
        {
            // Clear and reload orders 
            orders.Clear();
            Loadorder();

            if (driver != null)
            {
                if (orders.Any(o => o.GetDriver().GetId == driver.GetId))
                {
                    int orderIndex = orders.FindLastIndex(o => o.GetDriver().GetId == driver.GetId);
                    MessageBox.Show("Your Orders", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Return the found order
                    Order order1 = orders[orderIndex];
                    return order1;
                }
            }

            return null;
        }

        public Order CheckOrder(Customer customer)
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
        public Car GetCar(int Id)
        {
            Driver driver1 = drivers.Find(c => c.GetCar().GetCarId() == Id);
            Car car = new Car(
            driver1.GetCar().GetCarId(),     
            driver1.GetCar().GetModel(),     
            driver1.GetCar().GetPlateNumber(), 
            driver1.GetCar().IsAvailable() 
        );
            return car;
        }
        public Driver GetDriver(int Id)
        {
            drivers.Clear();
            LoadData();
            Driver driver = drivers.Find(c => c.GetId == Id);
            if (driver!= null)
            {
                return driver;
                
            }
            else
            {
                MessageBox.Show("Driver Not Found");
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
            string query = "SELECT d.Id, d.Identity, d.Name,d.UserName,d.Password, d.ContactNumber, d.IsAvailable, c.CarId as CarId, c.Model, c.PlateNumber,c.Available FROM Drivers d INNER JOIN Cars c ON d.Id = c.DriverID";
            Dbmanagement db = new Dbmanagement();
            DataTable dataTable = db.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                // Extract Car information from the current row
                int CarId = Convert.ToInt32(row["CarId"]);
                string? model = row["Model"].ToString();
                int PlateNumber = Convert.ToInt32(row["PlateNumber"]);
                bool IsAvailable = Convert.ToBoolean(row["Available"]);
                NextCarId = CarId + 1;
                Car car = new Car(CarId, model, PlateNumber, IsAvailable);
                // Extract driver information from the current row
                int ID = Convert.ToInt32(row["Id"]);
                int Identity = Convert.ToInt32(row["Identity"]);
                string? Name = row["Name"].ToString();
                string? UserName = row["UserName"].ToString();
                string? Password = row["Password"].ToString();
                int ContactNumber = Convert.ToInt32(row["ContactNumber"]);
                bool Available = Convert.ToBoolean(row["IsAvailable"]);
                drivers.Add(new Driver(UserName, Password, Name, ID, Identity, ContactNumber, Available,car));
                driverId = ID + 1;
                cars.Add(car);
                persons.Add(new Driver(UserName, Password, Name, ID, Identity, ContactNumber, Available, new Car(CarId, model, PlateNumber, IsAvailable)));
            }
            string query1 = "SELECT*from customers";
            DataTable dataTable1 = db.ExecuteQuery(query1);

            foreach (DataRow row in dataTable1.Rows)
            {

                int ID = Convert.ToInt32(row["Id"]);
                int Identity = Convert.ToInt32(row["Identity"]);
                string? Name = row["Name"].ToString();
                string? UserName = row["UserName"].ToString();
                string? Password = row["Password"].ToString();
                int ContactNumber = Convert.ToInt32(row["ContactNumber"]);
                customers.Add(new Customer(UserName, Password, Name, ID, Identity, ContactNumber));
                CustomerId = ID + 1;
                persons.Add(new Customer(UserName, Password, Name, ID, Identity, ContactNumber));
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
                OrderId = ID+1;
                orders.Add(new Order(ID,customer, driver, date, PickUp, Destination));


            }
        }
        
        public void AddPerson(Person person)
        {
            persons.Clear();
            drivers.Clear();
            customers.Clear();
            LoadData();
            try
            {
                // Validate input parameter
                if (person == null)
                {
                    throw new ArgumentNullException(nameof(person), "Person object cannot be null.");
                }

                // Load data
                LoadData();

                if (person is Driver driver)
                {
                    // Check for existing driver with the same identity, username, or car plate number
                    if (drivers.Any(d => d.GetIdentity == driver.GetIdentity))
                    {
                        MessageBox.Show("Driver already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (drivers.Any(d => d.GetUserName == driver.GetUserName))
                    {
                        MessageBox.Show("Username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (drivers.Any(d => d.GetCar()?.GetPlateNumber() == driver.GetCar()?.GetPlateNumber()))
                    {
                        MessageBox.Show("Car with the same Plate number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Add driver
                        persons.Add(driver);
                        drivers.Add(driver);
                        Carmanageble.AddCar(driver.GetCar(), driver);
                    }
                }
                else if (person is Customer customer)
                {
                    // Check for existing customer with the same identity, contact number, or username
                    if (customers.Any(c => c.GetIdentity == customer.GetIdentity))
                    {
                        MessageBox.Show("User already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (customers.Any(c => c.GetcontactNumber == customer.GetcontactNumber))
                    {
                        MessageBox.Show("Phone number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (customers.Any(c => c.GetUserName == customer.GetUserName))
                    {
                        MessageBox.Show("Username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Add customer
                        customers.Add(customer);
                        persons.Add(customer);
                        Carmanageble.AddCustomer(customer);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"Error adding person: {ex.Message}");
            }
        }

        public void RemovePersonById(int Id)
        {
            persons.Clear();
            drivers.Clear();
            customers.Clear();
            LoadData();
            Person person = persons.FirstOrDefault(p => p.GetId == Id);

            if (person != null)
            {
                if (person is Driver driver)
                {
                    persons.Remove(person);
                    drivers.Remove(driver);
                    Carmanageble.RemoveDriver(driver); 
                }
                else if (person is Customer customer)
                {
                    persons.Remove(person);
                    customers.Remove(customer);
                    Carmanageble.RemoveCustomer(customer.GetId); 
                }
            }
            else
            {
                MessageBox.Show("Person not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdatePerson(Person person)
        {
            persons.Clear();
            drivers.Clear();
            customers.Clear();
            LoadData();
            //Find the person to update
            Person existingPerson = persons.Find(p => p.GetId == person.GetId);
            if (existingPerson != null)
            {
                int index = persons.FindIndex(d => d.GetId == person.GetId);
                if (person is Driver driver)
                {
                    int indexdriver = drivers.FindIndex(d => d.GetId == driver.GetId);

                    // Check if the existing person's identity matches the new driver's identity
                    if (existingPerson.GetIdentity == driver.GetIdentity)
                    {
                        if (existingPerson.GetUserName == driver.GetUserName)
                        {
                            if (existingPerson is Driver driver1)
                            {
                                // Check if the existing driver's car plate number matches the new driver's car plate number
                                if (driver1.GetCar().GetPlateNumber() == driver.GetCar().GetPlateNumber())
                                {
                                    persons[index] = person;
                                    drivers[indexdriver] = driver;
                                    Carmanageble.UpdateCar(driver.GetCar());
                                    Carmanageble.UpdateDriver(driver);
                                }
                                // Check if any other driver has the same car plate number
                                else if (drivers.Any(c => c.GetCar().GetPlateNumber() == driver.GetCar().GetPlateNumber()))
                                {
                                    MessageBox.Show("Car with the same Platenumber already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    // Update the persons and drivers lists
                                    persons[index] = person;
                                    drivers[indexdriver] = driver;
                                    Carmanageble.UpdateCar(driver.GetCar());
                                    Carmanageble.UpdateDriver(driver);

                                }
                            }
                        }
                        // Check if any other driver has the same username
                        else if (drivers.Any(c => c.GetUserName == driver.GetUserName))
                        {
                            MessageBox.Show("Username is taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            persons[index] = person;
                            drivers[indexdriver] = driver;
                            Carmanageble.UpdateCar(driver.GetCar());
                            Carmanageble.UpdateDriver(driver);
                        }
                    }
                    // Check if any other driver has the same identity
                    else if (drivers.Any(c => c.GetIdentity == driver.GetIdentity))
                    {
                        MessageBox.Show("Driver with the same ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (drivers.Any(c => c.GetUserName == driver.GetUserName))
                    {
                        MessageBox.Show("Username is taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        persons[index] = person;
                        drivers[indexdriver] = driver;
                        Carmanageble.UpdateCar(driver.GetCar());
                        Carmanageble.UpdateDriver(driver);
                    }
                }
                else if (person is Customer customer)
                {
                    int indexcustomer = customers.FindIndex(d => d.GetId == customer.GetId);
                    if (existingPerson.GetcontactNumber == customer.GetcontactNumber)
                    {
                        persons[index] = person;
                        customers[indexcustomer] = customer;
                        Carmanageble.UpdateCustomer(customer);
                    }
                    // Check if any other customer has the same contact number
                    else if (customers.Any(c => c.GetcontactNumber == customer.GetcontactNumber))
                    {
                        MessageBox.Show("Contact Number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Check if the existing person's password matches the new customer's password
                    else if (existingPerson.GetPassword == customer.GetPassword)
                    {
                        persons[index] = person;
                        customers[indexcustomer] = customer;
                        Carmanageble.UpdateCustomer(customer);
                    }
                    // Check if any other customer has the same password
                    else if (customers.Any(c => c.GetPassword == customer.GetPassword))
                    {
                        MessageBox.Show("Password Can not be use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        persons[index] = person;
                        customers[indexcustomer] = customer;
                        Carmanageble.UpdateCustomer(customer);
                    }
                }
            }
        }
 
    }
}

