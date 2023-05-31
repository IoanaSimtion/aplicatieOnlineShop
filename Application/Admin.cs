using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Admin : User
    {
        private bool readClients;
        private bool editClients;
        private bool readProducts;
        private bool editProducts;
        public Admin()
        {

        }

        public Admin(bool readClients, bool editClients, bool readProducts, bool editProducts) 
        {
            this.readClients = readClients;
            this.editClients = editClients;
            this.readProducts = readProducts;
            this.editProducts = editProducts;
        }

        public bool ReadClients
        {
            get { return this.readClients; }
            set { this.readClients = value; }
        }

        public bool EditClients
        {
            get { return this.editClients; }
            set { this.editClients = value; }
        }

        public bool ReadProducts
        {
            get { return this.readProducts; }
            set { this.readProducts=value; }
        }

        public bool EditProducts
        {
            get { return this.editProducts; }
            set { this.editProducts = value; }
        }
    }
}
