using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static string str;
        static char[] checkArr;
        static bool[] usedChar;

        static void Main(string[] args)
        {
          str = Console.ReadLine();
            checkArr = new char[str.Length];
            usedChar = new bool[str.Length];
            GetCombinations(0);
            Console.WriteLine();
        }

        private static void GetCombinations(int index)
        {
            if (index>=checkArr.Length)
            {
                Console.Write(string.Join("",checkArr)+" ");
                return;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!usedChar[i])
                    {
                        usedChar[i] = true;
                        checkArr[index] = str[i];
                        GetCombinations(index + 1);
                        usedChar[i] = false;
                    }
                }
            }
           
        }
    }
}
