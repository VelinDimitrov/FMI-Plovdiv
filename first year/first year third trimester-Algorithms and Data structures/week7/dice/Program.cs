using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    class Program
    {
        static int[] arr;
        static int dices;
        static int sum;
        static void Main(string[] args)
        {
            Console.Write("Number of dices : ");
             dices = int.Parse(Console.ReadLine());
            Console.Write("Sum :");
             sum = int.Parse(Console.ReadLine());
            arr = new int[dices];
            PrintCombinations(0);
        }

        private static void PrintCombinations(int index)
        {
            if (index>=arr.Length)
            {
                if (arr.Sum()==sum)
                {
                    Console.WriteLine('['+String.Join(", ",arr)+']');
                }
                return;
            }
            else
            {
                for (int i = 1; i <= 6; i++)
                {
                    arr[index] = i;
                    PrintCombinations(index + 1);
                }
            }
            
        }
    }
}
