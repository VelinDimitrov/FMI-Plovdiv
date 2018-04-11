using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(factoriel(num));
        }

        private static int factoriel(int num)
        {
            if (num<2)
            {
                return 1;
            }
            return num * factoriel(num - 1);
        }
    }
}
