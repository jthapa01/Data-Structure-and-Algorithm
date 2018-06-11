using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class TreeApp
    {
        public static void Main(String[] args)
        {
            int value;
            Tree theTree = new Tree();
            theTree.Insert(50, 1.5);
            theTree.Insert(25, 1.2);
            theTree.Insert(75, 1.7);
            theTree.Insert(12, 1.5);
            theTree.Insert(37, 1.2);
            theTree.Insert(43, 1.7);
            theTree.Insert(30, 1.5);
            theTree.Insert(33, 1.2);
            theTree.Insert(87, 1.7);
            theTree.Insert(93, 1.5);
            theTree.Insert(97, 1.5);

            while (true)
            {
                Console.Write("Enter first letter of show, ");
                Console.Write("insert, find, delete, or traverse: ");
                int choice = GetChar();
                switch (choice)
                {
                    case 's':
                        theTree.DisplayTree();
                        break;
                    case 'i':
                        Console.Write("Enter value to insert: ");
                        value = GetInt();
                        theTree.Insert(value, value + 0.9);
                        break;
                    case 'f':
                        Console.Write("Enter value to find: ");
                        value = GetInt();
                        Node found = theTree.Find(value);
                        if(found != null)
                        {
                            Console.Write("Found: ");
                            found.DisplayNode();
                            Console.Write("\n");
                        }
                        else
                        {
                            Console.Write("Could not find");
                            Console.Write(value + '\n');
                        }
                        break;
                    case 'd':
                        Console.Write("Enter value to delete: ");
                        value = GetInt();
                        bool didDelete = theTree.Delete(value);
                        if (didDelete)
                        {
                            Console.Write("Deleted " + value + '\n');
                        }
                        else
                        {
                            Console.Write("Could not delete ");
                            Console.Write(value + '\n');
                        }
                        break;
                    case 't':
                        Console.Write("Enter type 1, 2 or 3: ");
                        value = GetInt();
                        theTree.Traverse(value);
                        break;
                    default:
                        Console.Write("Invalid Entry\n");
                        break;
                }//end switch
            }//end while
        }//end main()
//--------------------------------------------------------------------------------------------------------------
        public static String GetString()
        {
            return Console.ReadLine(); 
        }
//--------------------------------------------------------------------------------------------------------------
        private static int GetInt()
        {
            return Int32.Parse(GetString());
        }
//--------------------------------------------------------------------------------------------------------------
        public static char GetChar()
        {
            return GetString()[0]; 
        }
    }
}
