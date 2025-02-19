using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class UserManager
    {
        public static Form Login(List<Person> persons, string username, string password)
        {
            Person user = persons.Find(p => p.GetUserName == username && p.GetPassword == password);
            if (user is Driver driver)
            {
                /*DriverDashboard driverDashboard = new DriverDashboard(driver.GetId);
                driverDashboard.Show();
                return driverDashboard;*/
            }
            else if (user is Customer customer)
            {
                UserDashboard dashboard = new UserDashboard(customer.GetId);
                dashboard.Show();
                return dashboard;
            }

            else if (username == "admin" && password == "admin123")
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                return adminDashboard;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            return null;
        }
    }
}

