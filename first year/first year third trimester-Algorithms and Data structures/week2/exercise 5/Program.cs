using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_5
{
    class Program
    {

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string reversed = "";

            reverseString(command,ref reversed, command.Length-1);
            Console.WriteLine(reversed);
        }

        private static void reverseString(string command,ref string reversed,int length)
        {
            
            reversed += command[length--];
            if (length <0)
            {
                return;
            }
            reverseString(command,ref reversed, length);
        }
    }
}
