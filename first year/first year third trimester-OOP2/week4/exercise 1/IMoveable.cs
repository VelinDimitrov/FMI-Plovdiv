using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    interface IMoveable
    {
        void Move();
    }
    public class Circle : IMoveable
    {
        int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        

        void IMoveable.Move()
        {
            Console.WriteLine("Move circle");
        }
       
    }
}
