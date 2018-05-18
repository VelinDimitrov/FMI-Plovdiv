using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_inventory
{
    class Inventory
    {
       private List<Product> products;

        public Inventory()
        {
            products = new List<Product>();
        }

        public void Add(Product product)
        {
            if (!products.Contains(product))
            {
                products.Add(product);
            }
            else
            {
                int index = products.IndexOf(product);
                products[index].increaseStock();
            }
        }

        public void AddStock(Product product,int stock)
        {
            int index = products.IndexOf(product);
            if (index!=-1)
            {
                products[index].increaseStock(stock);
            }
            else
            {
                Console.WriteLine("Product does not exist!");
            }
        }

        public decimal calculateInventoryPrice()
        {
            decimal sum = 0;
            foreach (Product item in products)
            {
                sum += item.getPriceOfProduct();
            }
            return sum;
        }

        public override string ToString()
        {
            string str = "";
            foreach (var product in products)
            {
                str += product.ToString();
            }
            return str.ToString();
        }
    }
}
