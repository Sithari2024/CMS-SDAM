using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class OrderDataAccess
    {
        public static DataTable GetAllOrders(MySqlConnection connection)
        {
            DataTable ordersTable = new DataTable();
            string query = "SELECT * FROM Orders";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(ordersTable);
                }
            }

            return ordersTable;
        }
        public static void InsertOrder(MySqlConnection connection, int customerID, int driverID, int carID, string pickupLocation, string destination)
        {
            string query = "INSERT INTO Orders (CustomerID, DriverID, CarID, OrderDate, PickupLocation, Destination, OrderStatus) " +
                           "VALUES (@CustomerID, @DriverID, @CarID, @OrderDate, @PickupLocation, @Destination, @OrderStatus)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                // Set parameters
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@DriverID", driverID);
                cmd.Parameters.AddWithValue("@CarID", carID);
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@PickupLocation", pickupLocation);
                cmd.Parameters.AddWithValue("@Destination", destination);
                cmd.Parameters.AddWithValue("@OrderStatus", "Pending");

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // Handle exception or throw it further
                    throw;
                }
            }
        }
    }
}
