using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorInLinkedLists
{
    class LinkList
    {
        //private Link first;         //ref to first item on list
        public LinkList()
        {
            First = null;
        }
        //property First Link
        public Link First{get;set;} 

        public bool IsEmpty()       //true if list is empty
        {
            return First == null;
        }

        public ListIterator GetIterator()       //return iterator
        {
            return new ListIterator(this);      //initialize with this
        }                                       //(object of this class) list

        public void DisplayList()
        {
            Link current = First;
            while (current != null)
            {
                current.DisplayLink();          //print data
                current = current.next;         //move to next Link
            }
            Console.WriteLine();
        }
    }
}
