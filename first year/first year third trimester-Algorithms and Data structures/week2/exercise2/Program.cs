using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            int middleNumber = int.Parse(Console.ReadLine());
            
            for (int index = 0;  index < arr.Length; index++)
            {
                if (arr[index]>middleNumber)
                {
                    int[] temp = new int[arr.Length + 1];
                    //adding elements
                    for (int i = 0; i < index; i++)
                    {
                        temp[i] = arr[i];
                        
                    }
                    temp[index] = middleNumber;
                    for (int i = index+1; i < temp.Length; i++)
                    {
                        temp[i] = arr[i - 1];
                    }

                    arr = temp;

                    break;
                }
            }
            Console.WriteLine(String.Join(", ",arr));
        }
    }
}
