using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.models
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
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public void descriere()
        {
            string text = "";

            text += "Id-ul produsului este " + id + "\n";
            text += "Numele produsului este " + name + "\n";
            text += "Pretul produsului este " + price + "\n";
            text += "Descrierea produsului este " + description + "\n";
            text += "Stocul produsului este " + stock + "\n";
        }

    }
}
