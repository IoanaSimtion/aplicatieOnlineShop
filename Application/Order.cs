using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Order : OrderDetails
    {
        private string id;
        private string customerId;
        private int ammount;

        public Order()
        {

        }

        public Order(string id, string customerId, int ammount)
        {
            this.id = id;
            this.customerId = customerId;
            this.ammount = ammount;
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }

        public int Ammount
        {
            get { return this.ammount; }
            set { this.ammount = value; }
        }
    }
}
