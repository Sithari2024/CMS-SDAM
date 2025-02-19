using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_SDAM
{
    internal class Customer : Person
    {
        public Customer(string UserName, string Password, string name, int ID, int Identity, int ContactNumber) : base(UserName, Password, name, ID, Identity, ContactNumber)
        {

        }

        // Overridden method to get driver details
        public override void GetDetails()
        {
            int id = Convert.ToInt32(GetId);
            int ContactNummber = Convert.ToInt32(GetcontactNumber);
            string Name = GetName.ToString();
            int Identity = Convert.ToInt32(GetIdentity);
            string UserName = GetUserName.ToString();
            string Password = GetPassword.ToString();
        }
   
    }
}

