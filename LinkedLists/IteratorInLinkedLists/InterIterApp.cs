using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Demonstrates iterators on a linked ListIterator
namespace IteratorInLinkedLists
{
    class InterIterApp
    {
        static void Main(string[] args)
        {
            //delete all items with keys that are multiples of 3
            LinkList theListTest = new LinkList();
            ListIterator iterTest = theListTest.GetIterator();
            iterTest.InsertAfter(21);
            iterTest.InsertAfter(40);
            iterTest.InsertAfter(30);
            iterTest.InsertAfter(7);
            iterTest.InsertAfter(45);

            theListTest.DisplayList();      //display list
            iterTest.Reset();               //start at first link
            Link aLink = iterTest.GetCurrent(); //get it
            if(aLink.dData % 3 == 0)            //if divisible by 3
            {
                iterTest.DeleteCurrent();       //delete it
            }
            while (!iterTest.AtEnd())           //until the end of list
            {
                iterTest.NextLink();            //go to next link
                aLink = iterTest.GetCurrent();
                if(aLink.dData % 3 == 0)        //if divisible by 3
                {
                    iterTest.DeleteCurrent();   //delete
                }
            }
            theListTest.DisplayList();



            LinkList theList = new LinkList();
            ListIterator iter1 = theList.GetIterator();     //new iter
            long value;

            iter1.InsertAfter(20);
            iter1.InsertAfter(40);
            iter1.InsertAfter(80);
            iter1.InsertBefore(60);

            while (true)
            {
                Console.Write("Enter first letter of show, reset, ");
                Console.Write("next, get, before, after, delete: ");
                int choice = GetChar();

                switch (choice)
                {
                    case 's':
                        if (!theList.IsEmpty())
                        {
                            theList.DisplayList();
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        break;
                    case 'r':
                        iter1.Reset();
                        break;
                    case 'n':
                        if (!theList.IsEmpty() && !iter1.AtEnd())
                        {
                            iter1.NextLink();
                        }
                        else
                        {
                            Console.WriteLine("Can't go to next link");
                        }
                        break;
                    case 'g':               //get current item

                        if (!theList.IsEmpty())
                        {
                            value = iter1.GetCurrent().dData;
                            Console.WriteLine("Returned " + value);
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        break;

                    case 'b':               //Insert before current
                        Console.Write("Enter value to insert: ");
                        value = GetInt();
                        iter1.InsertBefore(value);
                        break;

                    case 'a':               //insert after current
                        Console.Write("Enter value to insert: ");
                        value = GetInt();
                        iter1.InsertAfter(value);
                        break;
                    case 'd':               //delete current item
                        if (!theList.IsEmpty())
                        {
                            value = iter1.DeleteCurrent();
                            Console.WriteLine("Deleted " + value);
                        }
                        else
                        {
                            Console.WriteLine("Cant delete");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }//end switch
            }//end while
            Console.ReadKey();
        }//end main

        private static int GetInt()
        {
            string s = GetString();
            return Int32.Parse(s);
        }

        private static char GetChar()
        {
            String s = GetString();
            return s[0];
        }

        private static string GetString()
        {
            return Console.ReadLine();
        }
    }
}
