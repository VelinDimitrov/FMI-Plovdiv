using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes
{
    class BTree
    {
        public BNode root;

        public BTree(int value,double water)
        {
            this.root = new BNode(value,100,water);
        }

        private void PrintTree(BNode node)
        {
            if (node == null)
            {
                return;
            }

            PrintTree(node.LeftChild);
            if (node.LeftChild==null &&node.RightChild==null)
            {
                Console.Write(node.Value);
                Console.WriteLine("\t" + node.Water);
            }
            PrintTree(node.RightChild);
        }

        public void PrintTree()
        {
            PrintTree(root);
        }
        
        

        public void Add(string information)
        {
            int[] info = information.Split(' ').Select(x=>int.Parse(x)).ToArray();

            BNode nodeToAddElementsIn = null;
            GetElement(info[0],root,ref nodeToAddElementsIn);

            if (nodeToAddElementsIn==null)
            {
                Console.WriteLine("Value not found.Wrong input!"); // test purpose
                return;
            }

            nodeToAddElementsIn.LeftChild=new BNode(info[1],info[2],nodeToAddElementsIn.Water);
            nodeToAddElementsIn.RightChild = new BNode(info[3], info[4], nodeToAddElementsIn.Water);
        }

        private void GetElement(int value, BNode currentNode,ref BNode returnNode)
        {
            if (currentNode==null)
            {
                return;
            }
            else if (value==currentNode.Value)
            {
                returnNode = currentNode;
                return;
            }

            GetElement(value, currentNode.LeftChild,ref returnNode);
            if (returnNode==null)
            {
                GetElement(value, currentNode.RightChild, ref returnNode);
            }

            return;
        }
    }
}
