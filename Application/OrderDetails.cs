using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class OrderDetails
    {
        private string orderId;
        private string productId;
        private int price;
        private int quantity;

        public OrderDetails()
        {

        }

        public OrderDetails(string productId, string orderId, int quantity, int price)
        {
            this.productId = productId;
            this.orderId = orderId;
            this.price= price;
            this.quantity = quantity;
        }

        public string ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }

        public string OrderId
        {
            get { return this.orderId; }
            set { this.orderId = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
    }
}
