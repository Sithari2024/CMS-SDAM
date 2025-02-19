using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class UserManager
    {
        
        public static int DriverId;

        // Method to handle user login
        public static Form Login(List<Person> persons, string username, string password)
        {
            
            Person user = persons.Find(p => p.GetUserName == username && p.GetPassword == password);
            if (user is Driver driver)
            {
               
                DriverId = driver.GetId;
                return new DriverDashboard();
            }
           
            else if (user is Customer customer)
            {
                UserDashboard userDashboard= new UserDashboard(customer.GetId);

                return userDashboard;
            }
            
            else if (username == "admin" && password == "admin123")
            {
                return new AdminDashboard();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}

