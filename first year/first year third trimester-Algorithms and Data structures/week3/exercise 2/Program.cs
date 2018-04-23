using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List <int> list= new List<int>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(5);
            queue.Enqueue(15);
            
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            Stack<int> myStack = new Stack<int>();
            myStack.Push(15);
            myStack.Push(20);
            myStack.Push(25);
            Console.WriteLine(myStack.Pop());
            
        }
    }
}
