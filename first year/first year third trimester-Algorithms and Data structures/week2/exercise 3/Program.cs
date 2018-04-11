using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    class Program
    {       
        static void Main(string[] args)
        {

            double[] arr = new double[0];

            int counter = 0;
            int numberOfCommands = int.Parse(Console.ReadLine());
            while (counter!=numberOfCommands)
            {
                string command= Console.ReadLine();
                if (command!="G")
                {
                    double num = double.Parse(command.Split(' ')[1]);
                    List<double> temp = arr.ToList();
                    temp.Add(num);
                    arr = temp.ToArray();
                }
                else
                {
                    findMedianne(arr);
                }
                counter++;
            }

           
        }

        private static void findMedianne(double[] arr)
        {
            Array.Sort(arr);
            double medianne;

            if (arr.Length % 2 == 1)
            {
                medianne = arr[arr.Length / 2];
            }
            else
            {
                int lastElementIndex = arr.Length - 1;
                medianne = (arr[lastElementIndex / 2] + arr[lastElementIndex / 2 + 1]) / 2;
            }

            Console.WriteLine("The medianne is:"+medianne);
            
        }
    }
}
