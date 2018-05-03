using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedLists
{
    class DoublyLinkedApp
    {
        static void Main(string[] args)
        {
            DoublyLinked theList = new DoublyLinked();
            theList.InsertFirst(22);
            theList.InsertFirst(66);

            theList.InsertLast(11);     //insert at rear
            theList.InsertLast(33);
            theList.InsertLast(55);

            theList.DisplayForward();   //display list forward  
            theList.DisplayBackward();  //display list backward

            theList.DeleteFirst();      //delete first item
            theList.DeleteLast();
            theList.DeleteKey(11);      //delete item with key 11

            theList.DisplayForward();   //display list forward

            theList.InsertAfter(22, 77); //insert 77 after 22
            theList.InsertAfter(33, 88); //insert 88 after 33

            theList.DisplayForward();
            Console.ReadLine();
        }
    }
}
