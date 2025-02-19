using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CMS_SDAM
{
    internal abstract class Person
    {
        private string name { get; set; }
        private int Identity { get; set; }
        private int ID { get; set; }
        private int ContactNumber { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        protected Person(string UserName, string Password, string name, int Id, int Identity, int ContactNumber)
        {
            this.name = name;
            this.Identity = Identity;
            this.ContactNumber = ContactNumber;
            this.ID = Id;
            this.Username = UserName;
            this.Password = Password;
        }
        public int GetIdentity
        {
            get { return Identity; }
        }
        public int GetId
        {
            get { return ID; }
        }

        public string GetName
        {
            get { return name; }
        }

        public int GetcontactNumber
        {
            get { return ContactNumber; }
        }
        public string GetUserName
        {
            get { return Username; }
        }
        public string GetPassword
        {
            get { return Password; }
        }
        public abstract void GetDetails();

    }
}
