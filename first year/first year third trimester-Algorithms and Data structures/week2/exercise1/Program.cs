using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            
            

            for (int i = 0; i < arr.Length/2; i++)
            {
                if (arr[i]!=arr[arr.Length-i-1])
                {
                    int temp = arr[i];
                    arr[i] = arr[arr.Length - i - 1];
                    arr[arr.Length - i - 1] = temp;
                }
            }
            Console.WriteLine(String.Join(", ",arr));
        }
    }
}
