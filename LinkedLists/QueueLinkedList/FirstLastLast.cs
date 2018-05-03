using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedList
{
    class FirstLastLast
    {
        private Link first;
        private Link last;
        public FirstLastLast()
        {
            first = null;
            last = null;
        }

        public bool IsEmpty()
        {
            return (first == null);
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
                last.next = newLink;           //old last--> newLink
            }
            last = newLink;                //newLink <--last
        }
        public long DeleteFirst()
        {
            long temp = first.dData;
            if (first.next == null)             //if only one item
            {
                last = null;
            }
            first = first.next;
            return temp;
        }
        public void DisplayList()
        {
            Link current = first;
            while(current != null)
            {
                current.DisplayLink();  //print data
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
