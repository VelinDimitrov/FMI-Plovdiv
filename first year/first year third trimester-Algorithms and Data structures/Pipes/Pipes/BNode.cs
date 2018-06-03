using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes
{
    class BNode
    {
        public BNode LeftChild { get; set; }
        public BNode RightChild { get; set; }
        public int Value { get; set; }
        public double Water { get; set; }

        public BNode(int value, double percent, double water)
        {
            this.Value = value;
            this.Water = (percent / 100) * water;
        }
    }
}
