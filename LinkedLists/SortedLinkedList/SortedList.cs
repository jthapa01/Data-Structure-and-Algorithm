using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLinkedList
{
    class SortedList
    {
        private Link first;
        public SortedList() //constructor
        {
            first = null;
        }
        public bool IsEmpty()
        {
            return (first == null);
        }
        public void Insert(long key)
        {
            Link newLink = new Link(key);       //make a new Link
            Link previous = null;               //start at first
            Link current = first;
            while(current != null && key> current.dData)
            {
                previous = current;
                current = current.next;         //go to next item
            }
            if(previous == null)                //at begining of list
            {
                first = newLink;                //first-> newLink
            }
            else
            {
                previous.next = newLink;        //old previous -->new Link
            }
            newLink.next = current;             //newLink-->old Current
        }
        public Link Remove()
        {
            Link temp = first;
            first = first.next;
            return temp;
        }
        public void DisplayList()
        {
            Console.Write("List (first-->last); ");
            Link current = first;                   //start at begining of a list
            while (current != null)                 //until end of list
            {
                current.DisplayLink();              //print data
                current = current.next;             //move to next Link
            }
            Console.WriteLine();
        }

    }
}
