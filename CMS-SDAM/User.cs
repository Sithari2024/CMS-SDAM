using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class User
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public User(int user_id, string username, string password, string role)
        {
            this.user_id = user_id;
            this.username = username;
            this.password = password;
            this.role = role;
        }
    }

}

