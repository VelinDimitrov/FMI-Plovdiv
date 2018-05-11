using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory clothesShop = new Inventory();

            Shirt blueShirt = new Shirt("Blue Shirt","T-Shirt",4.99m);
            Shirt yellowShirt = new Shirt("Yellow Shirt", "T-Shirt", 7.99m);
            Shirt anotherBlueShirt = new Shirt("Blue Shirt", "T-Shirt", 4.99m);
            Shirt greenShirt = new Shirt("Green Shirt", "T-Shirt", 10.99m);
            Shirt anotherGreenShirt = new Shirt("Green Shirt", "T-Shirt", 10.99m);

            Pants bluePants = new Pants("Blue Pants", "Blue jeans", 10.99m);
            Pants yellowPants = new Pants("Yellow Pantst", "Yellow Pants", 7.99m);
            Pants anotherBluePants = new Pants("Blue Pants", "Blue jeans", 10.99m);
            Pants greenPants = new Pants("Green Pants", "Green jeans", 22.99m);
            Pants anotherGreenPants = new Pants("Green Pants", "Green pantalon", 15.99m);
            Pants unknown = new Pants();
            Pants adidasGreenPants = new Pants("Green Pants", "Green pantalon", 15.99m,"Adidas");

            clothesShop.Add(blueShirt);
            clothesShop.Add(yellowShirt);
            clothesShop.Add(anotherBlueShirt);
            clothesShop.Add(greenShirt);
            clothesShop.Add(anotherGreenShirt);

            clothesShop.Add(bluePants);
            clothesShop.Add(yellowPants);
            clothesShop.Add(anotherGreenPants);
            clothesShop.Add(greenPants);
            clothesShop.Add(anotherBluePants);
            clothesShop.Add(unknown);
            clothesShop.Add(adidasGreenPants);

            Console.WriteLine("\t\t\t\tClothes Shop");
            
            Console.WriteLine(clothesShop.ToString());
            Console.WriteLine($"Whole Inventory : {clothesShop.calculateInventoryPrice()}$");
        }
    }
}
