using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.SimpleLinkedList
{
    class LinkList
    {
        private Link first;         //reference to first link on list

        //---------------------------------------------
        public LinkList()           //constructor
        {
            first = null;           //no items on list yet
        }
        //---------------------------------------------
        public bool IsEmpty()
        {
            return (first == null); //true if list is empty
        }
        //---------------------------------------------
        public void InsertFirst(int id, double dd)  //insert at start of the link
        {
            Link newLink = new Link(id, dd);        //make a new link
            newLink.next = first;                   //newLi --> old first
            first = newLink;                        //first --> newLink
        }
        //---------------------------------------------
        public Link Find(int key)       //fnd link with given key
        {                               //(assumes non-empty list)
            Link current = first;       //start at 'first'
            while(current.iData != key) //while no match 
            {
                if(current.next == null) //if end of list
                {                        //didnt find it
                    return null;
                }
                else                        //not end of list
                {
                    current = current.next;   //go to next link
                }
                
            }
            return current;                 //found it
        }
        //---------------------------------------------
        public Link Delete(int key)               //delete link with given key
        {                                         //assumes non-empty lsit)
            Link current = first;                 //search for link
            Link previous = first;
            while (current.iData != key)
            {
                if(current.next == null) 
                {
                    return null;                  //didnt find it
                }
                else
                {
                    previous = current;           //go to next link
                    current = current.next;
                }
            }
            if(current == first)                 //found it
            {
                first = first.next;              //if first link change first
            }
            else                                 //otherwise bypass it
            {
                previous.next = current.next;
            }
            return current;
        }
        //---------------------------------------------
        public Link DeleteFirst()                   //delete first item
        {                                           //assumes list not empty
            Link temp = first;                      //save reference to Link
            first = first.next;                     //delete it: first--> old.next
            return temp;                            //return deleted link
        }
        //---------------------------------------------
        public void DisplayList()
        {
            Console.Write("List (first-->last): ");
            Link current= first;                      //start at the beginning of the list
            while(current != null)                    //until end of list
            {
                current.DisplayLink();                //print data
                current = current.next;               //move to next
            }
            Console.WriteLine();
        }
    }//end class LinkList
}


