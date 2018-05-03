using System;

namespace IteratorInLinkedLists
{
    class ListIterator
    {
        private Link current;               //curent link
        private Link previous;              //previous link
        private LinkList ourList;           //our linked list

        public ListIterator(LinkList list)  //constructor
        {
            ourList = list;
            Reset();
        }

        public void Reset()                //start at first
        {
            current = ourList.First;
            previous = null;
        }

        public bool AtEnd()                //true if last link
        {
            return (current.next == null);
        }

        public void NextLink()              //go to next link
        {
            previous = current;
            current = current.next;
        }

        public Link GetCurrent()            //get current link
        {
            return current;
        }

        public void InsertAfter(long dd)    //insert after
        {                                   //current link
            Link newLink = new Link(dd);
            if (ourList.IsEmpty())
            {
                ourList.First=newLink;
                current = newLink;
            }
            else
            {
                newLink.next = current.next;
                current.next = newLink;
                NextLink();                 //point to new link
            }
        }

        public void InsertBefore(long dd)   //insert before
        {
            Link newLink = new Link(dd);
            if (previous == null)            //beginning of list
            {
                newLink.next = ourList.First;   //newLink refers to previous first
                ourList.First = newLink;
                Reset();
            }
            else                             //not beginning
            {
                newLink.next = previous.next;
                previous.next = newLink;
                current = newLink;
            }
        }

        public long DeleteCurrent()         //delete item at current
        {
            long value = current.dData;
            if (previous == null)
            {
                ourList.First = current.next;
                Reset();
            }
            else
            {
                previous.next = current.next;
                if (AtEnd())
                {
                    Reset();
                }
                else
                {
                    current = current.next;
                }
            }
            return value;
        }
    }
}