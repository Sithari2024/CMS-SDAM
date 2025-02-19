using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal static class DbConnector
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = $"server={DatabaseConfig.Server};user={DatabaseConfig.Username};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}";

            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
