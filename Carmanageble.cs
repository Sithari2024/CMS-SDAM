using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class Carmanageble
    {
        public static void AddCar(Car car, Driver driver)
        {
            try
            {
                Dbmanagement dbManagement = new Dbmanagement();

                // Add car
                string carInsertQuery = "INSERT INTO cars (CarId, Model, PlateNumber, Available) VALUES (@CarId, @Model, @PlateNumber, @Available)";
                var carParameters = new Dictionary<string, object>
        {
            { "@CarId", car.GetCarId() },
            { "@Model", car.GetModel() },
            { "@PlateNumber", car.GetPlateNumber() },
            { "@Available", car.IsAvailable() }
        };
                dbManagement.ExecuteNonQuery(carInsertQuery, carParameters);

                // Add driver
                string driverInsertQuery = "INSERT INTO drivers (Id, Identity, Name, UserName, Password, ContactNumber, IsAvailable, CarId) VALUES (@Id, @Identity, @Name, @UserName, @Password, @ContactNumber, @IsAvailable, @CarId)";
                var driverParameters = new Dictionary<string, object>
        {
            {"@ID", driver.GetId },
            {"@Identity",driver.GetIdentity},
            { "@Name",driver.GetName },
            {"@Password",driver.GetPassword },
            {"@UserName",driver.GetUserName },
            { "@ContactNumber", driver.GetcontactNumber },
            { "@IsAvailable", driver.IsAvailable()},
            { "@CarId", driver.GetCar().GetCarId()}
        };
                dbManagement.ExecuteNonQuery(driverInsertQuery, driverParameters);

                // Execute additional query to update the DriverId in the cars table
                string updateCarQuery = "UPDATE cars SET DriverId = @DriverId WHERE CarId = @CarId";
                var updateCarParameters = new Dictionary<string, object>
        {
            {"@DriverId",driver.GetId},
            { "@CarId", driver.GetCar().GetCarId() }
        };
                dbManagement.ExecuteNonQuery(updateCarQuery, updateCarParameters);

                MessageBox.Show("Car & Driver Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void UpdateCar(Car car)
        {
            try
            {
                Dbmanagement dbManagement = new Dbmanagement();

                // Update car
                string query = "UPDATE cars SET Model = @Model, PlateNumber = @PlateNumber, Available = @IsAvailable WHERE CarId = @CarId";
                var parameters = new Dictionary<string, object>
                {
                    { "@CarId", car.GetCarId() },
                    { "@Model", car.GetModel() },
                    { "@PlateNumber", car.GetPlateNumber() },
                    { "@IsAvailable", car.IsAvailable()}
                };
                dbManagement.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Car Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static DataTable Viewcar()
        {
            string query = "SELECT * FROM cars ";
            Dbmanagement dbmanagement = new Dbmanagement();
            DataTable DT = dbmanagement.ExecuteQuery(query);
            return DT;
        }

        public static DataTable ViewAvailableCar()
        {
            string query = "SELECT * FROM cars where Available=true";
            Dbmanagement dbmanagement = new Dbmanagement();
            DataTable DT = dbmanagement.ExecuteQuery(query);
            return DT;
        }
        public static DataTable ViewDriver()
        {
            string query = "SELECT * FROM drivers ";
            Dbmanagement dbmanagement = new Dbmanagement();
            DataTable DT = dbmanagement.ExecuteQuery(query);
            return DT;
        }
        public static DataTable ViewCustomer()
        {
            string query = "SELECT * FROM customers ";
            Dbmanagement dbmanagement = new Dbmanagement();
            DataTable DT = dbmanagement.ExecuteQuery(query);
            return DT;
        }
        public static DataTable Vieworders()
        {
            string query = "SELECT * FROM orders ";
            Dbmanagement dbmanagement = new Dbmanagement();
            DataTable DT = dbmanagement.ExecuteQuery(query);
            return DT;
        }
        public static void RemoveDriver(Driver driver)
        {
            try
            {
                string driverQuery = "DELETE FROM drivers WHERE Id = @Id";
                var driverParameters = new Dictionary<string, object>
        {
            { "@Id", driver.GetId }
        };

                Dbmanagement dbManagement = new Dbmanagement();
                dbManagement.ExecuteNonQuery(driverQuery, driverParameters);
                MessageBox.Show("Driver Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Remove the associated car from the cars table
                string carQuery = "DELETE FROM cars WHERE PlateNumber = @PlateNumber";
                var carParameters = new Dictionary<string, object>
        {
            { "@PlateNumber", driver.GetCar().GetPlateNumber() }
        };

                dbManagement.ExecuteNonQuery(carQuery, carParameters);
                MessageBox.Show("Car Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void UpdateDriver(Driver driver)
        {
            try
            {
                string query = "UPDATE drivers SET Identity=@Identity, Name=@Name, UserName=@UserName, Password=@Password, ContactNumber=@ContactNumber, IsAvailable=@IsAvailable WHERE Id=@ID";
                var parameters = new Dictionary<string, object>
            {   {"@ID", driver.GetId },
                {"@Identity",driver.GetIdentity},
                { "@Name",driver.GetName },
                {"@Password",driver.GetPassword },
                {"@UserName",driver.GetUserName },
                { "@ContactNumber", driver.GetcontactNumber },
                { "@IsAvailable", driver.IsAvailable()}
        };

                Dbmanagement dbManagement = new Dbmanagement();
                dbManagement.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Driver Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddCustomer(Customer customer)
        {
            try
            {
                string customerQuery = "INSERT INTO customers (Id, Identity, Name, UserName, Password, ContactNumber) VALUES (@ID, @Identity, @Name, @UserName, @Password, @ContactNumber)";
                var customerParameters = new Dictionary<string, object>
        {
            {"@ID", customer.GetId },
            {"@Identity",customer.GetIdentity},
            { "@Name",customer.GetName },
            {"@Password",customer.GetPassword },
            {"@UserName",customer.GetUserName },
            { "@ContactNumber", customer.GetcontactNumber }
        };

                Dbmanagement dbManagement = new Dbmanagement();
                dbManagement.ExecuteNonQuery(customerQuery, customerParameters);
                MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void UpdateCustomer(Customer customer)
        {
            try
            {
                string query = "UPDATE customers SET Identity=@Identity, Name=@Name, UserName=@UserName, Password=@Password, ContactNumber=@ContactNumber WHERE Id=@ID";
                var parameters = new Dictionary<string, object>
        {
           { "@ID", customer.GetId },
            {"@Identity",customer.GetIdentity},
            { "@Name",customer.GetName },
            {"@Password",customer.GetPassword },
            {"@UserName",customer.GetUserName},
            { "@ContactNumber", customer.GetcontactNumber },
        };

                Dbmanagement dbmanagement = new Dbmanagement();
                dbmanagement.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Customer Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RemoveCustomer(int Id)
        {
            try
            {
                string query = "DELETE FROM customers WHERE Id = @Id";
                var parameters = new Dictionary<string, object>
        {
            { "@Id", Id }
        };

                Dbmanagement dbmanagement = new Dbmanagement();
                dbmanagement.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Customer Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void AddOrder(Order order)
        {
            try
            {
                string query = "INSERT INTO orders (Destination, PickUp, DriverId, CustomerId, CarId, Date,Id) VALUES (@Destination, @Pickup, @DriverId, @CustomerId, @CarId, @Date,@Id)";
                var parameters = new Dictionary<string, object>
        {
             {"@Id",order.nextOrderId },
            {"@Destination",order.Destination},
            {"@Pickup",order.Pickup },
            {"@DriverId",order.GetDriver().GetId },
            {"@CustomerId",order.GetCustomer().GetId },
            {"@CarId",order.GetDriver().GetCar().GetCarId() },
            { "@Date", order.Date }
        };

                Dbmanagement dbManagement = new Dbmanagement();
                dbManagement.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Order Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteOrder(int id)
        {
            try
            {
                string query = "DELETE FROM orders WHERE Id = @Id";
                var parameters = new Dictionary<string, object>
        {
            { "@Id", id }
        };

                Dbmanagement dbManagement = new Dbmanagement();
                dbManagement.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Order Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


