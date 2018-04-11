using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonachi = int.Parse(Console.ReadLine());
            Console.WriteLine(fib(fibonachi));
        }

        private static int fib(int fibonachi)
        {
            if (fibonachi<=2)
            {
                return 1;
            }
            return fib(fibonachi - 2) + fib(fibonachi - 1);
        }
    }
}
