using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamonds_4_Velin_Dimitrov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter one side Diamonds :");
            int dominoOneSideDiamonds = int.Parse(Console.ReadLine());
            int totalDiamonds = (dominoOneSideDiamonds + 2) * (dominoOneSideDiamonds*(dominoOneSideDiamonds+1)/2);
            Console.WriteLine("Total Diamonds :"+totalDiamonds);
        }
    }
}
