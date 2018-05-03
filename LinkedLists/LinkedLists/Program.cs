using LinkedLists.SimpleLinkedList;
using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList theList = new LinkList();      //make new list
            theList.InsertFirst(22, 2.99);
            theList.InsertFirst(44, 4.99);
            theList.InsertFirst(66, 6.99);
            theList.InsertFirst(88, 8.99);

            //theList.DisplayList();
            //while (!theList.IsEmpty())
            //{
            //    Link aLink = theList.DeleteFirst();  //delete link
            //    Console.Write("Deleted ");           //display it
            //    aLink.DisplayLink();
            //    Console.WriteLine();
            //}
            theList.DisplayList();                   //display list
            Link f = theList.Find(44);               //find item
            if (f != null)
            {
                Console.WriteLine("Found link with key " + f.iData);
            }
            else
            {
                Console.WriteLine("Cant find Link");
            }

            Link d = theList.Delete(66);    //delete item
            if (d != null)
            {
                Console.WriteLine("Deleted link with key "+ d.iData);
            }
            else
            {
                Console.WriteLine("Can't delete Link");
            }
            theList.DisplayList();


            Console.ReadLine();
        }//end main
    }//end class Program
}
