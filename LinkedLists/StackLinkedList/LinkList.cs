using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedList
{
    class LinkList
    {
        private Link first;
        public LinkList()
        {
            first = null;
        }
        public bool IsEmpty()
        {
            return (first == null);
        }
        public void InsertFirst(long dd)
        {
            Link newLink = new Link(dd);
            newLink.next = first;         //newLink -> oldfirst
            first = newLink;
        }
        public long DeleteFirst()
        {
            Link temp = first;
            first = first.next;
            return temp.dData;
        }
        public void DisplayList()
        {
            Link current = first;//start at begining
            while (current != null)
            {
                current.DisplayLink();
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
