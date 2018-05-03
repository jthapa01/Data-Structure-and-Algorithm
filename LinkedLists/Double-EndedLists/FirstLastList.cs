using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleEndedLists
{
    class FirstLastList
    {
        private Link first;
        private Link last;

        public FirstLastList()
        {
            first = null;
            last = null;
        }
        
        public bool IsEmpty()
        {
            return (first == null);
        }
        public void InsertFirst(long dd)
        {
            Link newLink = new Link(dd);
            if (IsEmpty())
            {
                last = newLink;
            }
            newLink.next = first; //old first
            first = newLink;
        }
        public void InsertLast(long dd)
        {
            Link newLink = new Link(dd);
            if (IsEmpty())
            {
                first = newLink;
            }
            else
            {
                last.next = newLink;
            }
            last = newLink;
        }
        public long DeleteFirst()//delete first link
        {
            long temp = first.dData;
            if(first.next == null)//if only one item
            {
                last = null;
            }
            first = first.next;
            return temp;
        }
        public void DisplayList()
        {
            Console.Write("first-->last): ");
            Link current = first;
            while (current != null)
            {
                current.DisplayLink();
                current = current.next;
            }
            Console.WriteLine();
        }

    }

}
