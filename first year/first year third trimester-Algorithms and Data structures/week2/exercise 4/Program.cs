using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_4
{
    class Program
    {

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            PrintNumbers(number,counter);
        }

        private static void PrintNumbers(int number,int counter)
        {
            Console.WriteLine(counter);
            if (number==counter)
            {
                return;
            }            
            PrintNumbers(number,++counter);
        }
    }
}
