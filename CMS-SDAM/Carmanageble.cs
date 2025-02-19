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
                string carInsertQuery = "INSERT INTO cars (CarId, Model, PlateNumber, Available, DriverId) VALUES (@CarId, @Model, @PlateNumber, @Available, @DriverId)";
                var carParameters = new Dictionary<string, object>
                {
                    { "@CarId", car.GetCarId() },
                    { "@Model", car.GetModel() },
                    { "@PlateNumber", car.GetPlateNumber() },
                    { "@Available", car.IsAvailable() },
                    {"@DriverId",driver.GetId}
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

                MessageBox.Show("Car & Driver Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void UpdateCar(Car car)
        {
            try
            {
                Dbmanagement dbManagement = new Dbmanagement();

                // Update car
                string query = "UPDATE cars SET Model = @Model, PlateNumber = @PlateNumber, Available = @Available WHERE CarId = @CarId";
                var parameters = new Dictionary<string, object>
                {
                    { "@CarId", car.GetCarId() },
                    { "@Model", car.GetModel() },
                    { "@PlateNumber", car.GetPlateNumber() },
                    { "@Available", car.IsAvailable() }
                };
                dbManagement.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Car Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static DataTable ViewCar()
        {
            try
            {
                string query = "SELECT * FROM cars";
                Dbmanagement dbManagement = new Dbmanagement();
                return dbManagement.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public static DataTable ViewDriver()
        {
            try
            {
                string query = "SELECT * FROM drivers";
                Dbmanagement dbManagement = new Dbmanagement();
                return dbManagement.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public static void RemoveDriver(Driver driver)
        {
            try
            {
                Dbmanagement dbManagement = new Dbmanagement();

                // Delete driver
                string driverDeleteQuery = "DELETE FROM drivers WHERE Id = @Id";
                var driverParameters = new Dictionary<string, object>
                {
                    { "@Id", driver.GetId }
                };
                dbManagement.ExecuteNonQuery(driverDeleteQuery, driverParameters);

                // Delete associated car
                string carDeleteQuery = "DELETE FROM cars WHERE PlateNumber = @PlateNumber";
                var carParameters = new Dictionary<string, object>
                {
                    { "@PlateNumber", driver.GetCar().GetPlateNumber() }
                };
                dbManagement.ExecuteNonQuery(carDeleteQuery, carParameters);

                MessageBox.Show("Driver and associated car removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void UpdateDriver(Driver driver)
        {
            try
            {
                Dbmanagement dbManagement = new Dbmanagement();

                // Update driver
                string query = "UPDATE drivers SET Identity = @Identity, Name = @Name, UserName = @UserName, Password = @Password, ContactNumber = @ContactNumber, IsAvailable = @IsAvailable WHERE Id = @Id";
                var parameters = new Dictionary<string, object>
                {
                    { "@ID", driver.GetId },
                    {"@Identity",driver.GetIdentity},
                    { "@Name",driver.GetName },
                    {"@Password",driver.GetPassword },
                    {"@UserName",driver.GetUserName },
                    { "@ContactNumber", driver.GetcontactNumber },
                    { "@IsAvailable", driver.IsAvailable()}
                };
                dbManagement.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Driver Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void UpdateCustomer(Customer customer)
        {
            try
            {
                Dbmanagement dbManagement = new Dbmanagement();

                // Update customer
                string query = "UPDATE customers SET Name = @Name, UserName = @UserName, Password = @Password, ContactNumber = @ContactNumber WHERE Id = @Id";
                var parameters = new Dictionary<string, object>
                {
                    { "@ID", customer.GetId },
                    {"@Identity",customer.GetIdentity},
                    { "@Name",customer.GetName },
                    {"@Password",customer.GetPassword },
                    {"@UserName",customer.GetUserName},
                    {"@ContactNumber", customer.GetcontactNumber },
                };
                dbManagement.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Customer Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void RemoveCustomer(int Id)
        {
            try
            {
                Dbmanagement dbManagement = new Dbmanagement();

                // Delete customer
                string query = "DELETE FROM customers WHERE Id = @Id";
                var parameters = new Dictionary<string, object>
                {
                    { "@Id", Id }
                };
                dbManagement.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Customer Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}


