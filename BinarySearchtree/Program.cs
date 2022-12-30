using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchtree
{
    class Node 
    {
        public String info;
        public Node leftchild;
        public Node rightchild;

        // contructor
        public Node(String i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null;
        }

        public void insert(string element)
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null)
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else
            {
                tmp = new Node(element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;
                }else if(string.Compare(element, parent.info)< 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
