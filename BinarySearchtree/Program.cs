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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
