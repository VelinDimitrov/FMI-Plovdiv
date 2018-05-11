using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_inventory
{
    class Shirt:Product
    {
        public Shirt(string title, string description, decimal price) :
            base(title, description, price)
        {

        }
        public Shirt(string title, string description, decimal price,string brand) :
            base(title, description, price,brand)
        {

        }
        public Shirt() : 
            base()
        {

        }
    }
}
