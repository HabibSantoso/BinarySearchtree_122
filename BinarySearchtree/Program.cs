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

        public void search(string element, ref Node parent, ref Node currentNode)
        {
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                {
                    currentNode = currentNode.leftchild;
                }
                else
                {
                    currentNode = currentNode.rightchild;
                }
            }
        }

        public void inorder(Node ptr)
        {
            if(ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if(ptr != null)
            {
                inorder(ptr.leftchild);
                Console.Write(ptr.info + " ");
                inorder(ptr.rightchild);
            }
        }

        public void preorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.Write(ptr.info + " ");
                preorder(ptr.leftchild);
                preorder(ptr.rightchild);
            }
        }

        public void postoder(Node ptr)
        {

            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                postoder(ptr.leftchild);
                postoder(ptr.rightchild);
                Console.Write(ptr.info + " ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree x = new BinaryTree();
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("\n***Menu***\n");
                    Console.WriteLine("1. Implement insert opration");
                    Console.WriteLine("2. Perform inorde traversal");
                    Console.WriteLine("3. Perform preorde traversal");
                    Console.WriteLine("4. Perform postorde traversal");
                    Console.WriteLine("5. exit");
                    Console.Write("\nEnter your choice: ");
                    String sInput = Console.ReadLine();
                    char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter");
                                string word = Console.ReadLine();
                            }
                            break;
                        case '2':
                            {
                                x.inorder(x.ROOT);
                            }
                            break;
                        case '3':
                            {
                                x.preorder(x.ROOT);
                            }
                            break;
                        case '4':
                            {
                                x.postoder(x.ROOT);
                            }
                            break;
                        case '5':
                            return;
                        default:
                            Console.WriteLine("\nInvalid choice");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Check for the values entered");
                }

            }
        }
    }
}
