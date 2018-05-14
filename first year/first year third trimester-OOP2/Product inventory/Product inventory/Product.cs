using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_inventory
{
   abstract class Product
    {
        private const string NO_BRAND = "Brand missing";
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int stock=1;

        public int Stock
        {
            get { return stock; }
            
        }
        public void increaseStock()
        {
            stock++;
        }
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Product()
        {
            Title = "Unknown";
            Description = "Unknown";
            Price = 0m;
            Brand = "Unknown";
        }
        
        public Product(string title, string description, decimal price)
        {
            Title = title;
            Description = description;
            Price = price;
            
        }
        public Product(string title,string description,decimal price,string brand)
        {
            Title = title;
            Description = description;
            Price = price;
            Brand = brand;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product)|| obj==null)
            {
                return false;
            }

            Product prod = (Product)obj;

            bool comparing = this.title == prod.title;
            if (comparing)
            {
                comparing = this.description == prod.description;
                if (comparing)
                {
                    comparing = this.price == prod.price;
                    if (comparing)
                    {
                        comparing = this.brand == prod.brand;
                    }
                }
            }
            return comparing;
        }

        public decimal getPriceOfProduct()
        {
            return stock * price;
        }

        public override string ToString()
        {
            //check if the product has information(it is not Unknown)
            if (title =="Unknown")
            {
                return "";
            }
            return $"Title :{title} \nDescription :{description}\nPrice:{price}$\nBrand={(brand!=null?brand:NO_BRAND)}\nQuantity:{stock}\n\n";
        }

    }
}
    