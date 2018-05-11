using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_inventory
{
    class Pants: Product
    {
        public Pants(string title, string description, decimal price,string brand) :
            base(title ,description,price,brand)
        {
            
        }
        public Pants(string title, string description, decimal price) :
            base(title, description, price)
        {

        }
        public Pants() :
            base(){

        }

    }
}
