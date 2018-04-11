using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int counter = 0;
            while (counter++<numberOfCommands)
            {
                string[] inputLine = Console.ReadLine().Split(' ');
                string command = inputLine[1];
                int firstNum = int.Parse(inputLine[0]);
                int secondNum = int.Parse(inputLine[2]);

                int index = list.IndexOf(secondNum);
                if (index == -1)
                {
                    list.Add(secondNum);
                    index = list.IndexOf(secondNum);
                }

                if (command=="before")
                {
                    if (list.Contains(firstNum))
                    {
                        continue;
                    }
                    list.Insert(index, firstNum);
                }
                else
                {
                    if (list.Contains(firstNum))
                    {
                        continue;
                    }
                    list.Insert(index+1, firstNum);
                }
            }
            Console.WriteLine(String.Join(", ",list));
        }
    }
}
