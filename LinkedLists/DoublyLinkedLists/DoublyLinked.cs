using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedLists
{
    class DoublyLinked
    {
        private Link first;             //ref to first              
        private Link last;              //ref to last item
        public DoublyLinked()
        {
            first = null;
            last = null;
        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void InsertFirst(long dd)            //insert at front of List
        {
            Link newLink = new Link(dd);            //make a new Link
            if (IsEmpty())                          //if empty list
            {
                last = newLink;                     //newLink <--last
            }
            else
            {
                first.previous = newLink;           //newLink <--old first
            }   
            newLink.next = first;                   //newLink -->old first
            first = newLink;                        //first-->newLink
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
                newLink.previous = last;
                
            }
            last = newLink;
        }

        public Link DeleteFirst()                   //delete first link
        {                                           //assumes non-empty list
            Link temp = first;                      
            if(first.next == null)                  //if only one item
            {
                last = null;                        //null<--last
            }
            else
            {
                first.next.previous = null;         //null <-- old next 
            }
            first = first.next;                     //first --> old next
            return temp;
        }
        public Link DeleteLast()
        {
            Link temp = last;
            if(first.next == null)                  //if only one item
            {
                first = null;                       //first --> null
            }
            else
            {
                last.previous.next = null;          //old previous --> null
            }
            last = last.previous;                   //old previous <-- last
            return temp;
        }
        public bool InsertAfter(long key, long dd)  //insert dd right after key
        {                                           //assumes non empty list
            Link current = first;                   //start at beginning
            while(current.dData != key)
            {
                current = current.next;             //move to next link
                if(current == null)
                {
                    return false;                   //didnt find it
                }
            }
            Link newLink = new Link(dd);            //make a new link
            if(current == last)                     //if last link
            {
                newLink.next = null;                //newLink --> null
                last = newLink;                     //newlink <-- last
            }
            else
            {
                newLink.next = current.next;        //referece to next one ; newlink --> old next
                current.next.previous = newLink;    //reference from previous: newLink <--old next
            }
            newLink.previous = current;             //old current <--newLink
            current.next = newLink;                 //old current --> newLink
            return true;
        }    
        public Link DeleteKey(long key)             //delete item with given key
        {                                           //assumes non empty
            Link current = first;                   //start at beginning
            while (current.dData != key)            //until match is found
            {
                current = current.next;             //move to next link
                if (current == null)
                {
                    return null;                    //didn't find it
                }
            }
            if(current == first)                    //found it; first item?
            {
                first = current.next;               //first -->old next
            }
            else                                    //not first
            {//forward direction reference
                current.previous.next = current.next;   //old previous --> old next
            }
            if(current == last)                     //last item?
            {
                last = current.previous;            //old previous <-- last
            }
            else
            {//backward direction reference
                current.next.previous = current.previous;   //old previous <--old next
            }
            return current;                         //return value
        }
        public void DisplayForward()
        {
            Console.Write("List (first --> last): ");
            Link current = first;                   //start at beginning
            while (current != null)                 //until end of list
            {
                current.DisplayLink();              //display data
                current = current.next;             //move to nex link
            }
            Console.WriteLine();
        }
        public void DisplayBackward()
        {
            Console.Write("List (Last --> first): ");
            Link current = last;                    //start at the end
            while (current != null)                 //until beginning
            {
                current.DisplayLink();              //display data
                current = current.previous;         //move to previous link
            }
            Console.WriteLine();
        }
    }

}
