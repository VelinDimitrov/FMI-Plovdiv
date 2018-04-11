using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = { "gosho","pesho","Ivan"};
            string[] secondArr = { "gosho", "pesho" };

            if (compareArrays(firstArr,secondArr))
            {
                Console.WriteLine("Ravni sa");
            }
            else
            {
                Console.WriteLine("ne sa ravni");
            }
        }

        private static bool compareArrays(string[] firstArr, string[] secondArr)
        {
            if (firstArr.Length!=secondArr.Length)
            {
                return false;
            }
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i]!=secondArr[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
