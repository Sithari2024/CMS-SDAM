using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class DriverDataAccess
    {
        /*public static DataTable GetAllDrivers(MySqlConnection connection)
        {
            DataTable driversTable = new DataTable();
            string query = "SELECT * FROM Drivers";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(driversTable);
                }
            }

            return driversTable;
        }*/
        public static DataTable GetAvailableDrivers(MySqlConnection connection)
        {
            DataTable availableDriversTable = new DataTable();
            string query = "SELECT DriverId, Name, ContactNumber, IF(AvailabilityStatus, 'Available', 'Not Available') AS Availability FROM Drivers WHERE AvailabilityStatus = @Availability";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                // Use parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@Availability", true);

                try
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(availableDriversTable);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error while retrieving available drivers: " + ex.Message);
                }
            }

            return availableDriversTable;
        }


        /*public static void AddDriver(MySqlConnection connection, string name, long contactNumber, bool availabilityStatus)
        {
            string query = "INSERT INTO Drivers (Name, ContactNumber, AvailabilityStatus) VALUES (@Name, @ContactNumber, @AvailabilityStatus)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@AvailabilityStatus", availabilityStatus);

                cmd.ExecuteNonQuery();
            }*/

        /*public static void RemoveDriver(MySqlConnection connection, int driverId)
        {
            string query = "DELETE FROM Drivers WHERE DriverId = @DriverId";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@DriverId", driverId);

                cmd.ExecuteNonQuery();
            }
        }*/
    }
}

