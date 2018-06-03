using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double waterQuantity = double.Parse(Console.ReadLine());
            BTree tree = new BTree(1,waterQuantity);
            int numberOfTubes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTubes/2; i++)
            {
                string tubeInformation = Console.ReadLine();
                tree.Add(tubeInformation);
            }
            tree.PrintTree();
        }
    }
}
