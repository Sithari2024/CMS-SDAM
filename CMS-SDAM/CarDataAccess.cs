using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class CarDataAccess
    {
        /*public static DataTable GetAllCars(MySqlConnection connection)
        {
            DataTable carsTable = new DataTable();
            string query = "SELECT * FROM Cars";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(carsTable);
                }
            }

            return carsTable;
        }*/

        /*public static DataTable GetAvailableCars(MySqlConnection connection)
        {
            DataTable availableCarsTable = new DataTable();
            string query = "SELECT CarID, Model, PlateNumber, IF(Availability, 'Available', 'Not Available') AS Availability FROM Cars WHERE Availability = TRUE";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(availableCarsTable);
                }
            }

            return availableCarsTable;
        }*/

        /*public static void AddCar(MySqlConnection connection, string model, string plateNumber, string availability)
        {
            string query = "INSERT INTO Cars (Model, PlateNumber, Availability) VALUES (@Model, @PlateNumber, @Availability)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                cmd.Parameters.AddWithValue("@Availability", availability);

                cmd.ExecuteNonQuery();
            }
        }*/

        /*public static void RemoveCar(MySqlConnection connection, string plateNumber)
        {
            string query = "DELETE FROM Cars WHERE PlateNumber = @PlateNumber";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);

                cmd.ExecuteNonQuery();
            }
        }*/
    }
}

