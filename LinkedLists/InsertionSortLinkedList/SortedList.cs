using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortLinkedList
{
    class SortedList
    {
        public Link first;
        public SortedList()
        {
            first = null;
        }
        public SortedList(Link[] linkArr)       //constructor array argument
        {
            first = null;
            for(int j = 0; j < linkArr.Length; j++)
            {
                Insert(linkArr[j]);
            }

        }

        private void Insert(Link link)
        {
            Link previous = null;               //start at first
            Link current = first;
            while (current !=null && link.dData > current.dData)
            {//until end of list
                previous = current;
                current = current.next;         //go to next item
            }
            if (previous == null)               //at begining of list
            {
                first = link;                   //first --> elem
            }
            else                                //not at beginning
            {
                previous.next = link;           //old prev -->link
            }
            link.next = current;                //link-->old current
        }
        public Link Remove()                    //return & delete first link
        {
            Link temp = first;                  //save first        
            first = first.next;                 //delete first
            return temp;                        //return value
        }
    }

}
