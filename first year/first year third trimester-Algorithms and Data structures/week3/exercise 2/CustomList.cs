using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    class CustomList<T>
    {
        private T[] container;
        private int counter;
        
        public CustomList()
        {
            this.container = new T[4];
        }
    }
}
