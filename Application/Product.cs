using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Product
    {
        private string id;
        private string name;
        private int price;
        private string description;
        private string image;
        private DateTime date;
        private int stock;
        
        public Product()
        {

        }

        public Product(string id, string name, int price, string description, string image, int stock, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.image = image;
            this.date = date;
            this.stock = stock;
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        public string Image
        {
            get { return this.image; }
            set { this.image = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public void descriere()
        {
            string text = "";

            text += "Id-ul produsului este " + this.id + "\n";
            text += "Numele produsului este " + this.name + "\n";
            text += "Pretul produsului este " + this.price + "\n";
            text += "Descrierea produsului este " + this.description + "\n";
            text+="Stocul produsului este "+this.stock + "\n"; 
        }

    }
}
