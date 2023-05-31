using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class User
    {
        private string id;
        private string email;
        private string password;
        private string fullName;
        private string address;
        private string type;

        public User()
        {

        }

        public User(string type, string id, string email, string password, string fullName, string address)
        {
            this.type = type;
            this.id = id;
            this.email = email;
            this.address = address;
            this.password = password;
            this.fullName = fullName;
        }

        public User(string properties)
        {
            string[] propr = properties.Split(",");

            this.type = propr[0];
            this.id = propr[1];
            this.fullName = propr[2];
            this.email = propr[3];
            this.password = propr[4];
            this.address = propr[5];
            
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string descriereUser()
        {
            string text = "";

            text += "Id-ul userului este " + this.id + "\n";
            text += "Numele userului este " + this.fullName + "\n";
            text += "Emailul userului este " + this.email + "\n";
            text+="Parola userului este "+this.address + "\n";
            text += "Adresa userului este" + this.address + "\n";

            return text;
        }
                
    }
}
