using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.SimpleLinkedList
{
    class Link
    {
        public int iData;             //data itm (key)
        public double dData;          //data item
        public Link next;             //next link in list
        //--------------------------------------------------
        public Link(int id, double dd) //constructor
        {
            iData = id;               //initialize data
            dData = dd;               //next is automatically set to null
        }
        //---------------------------------------------------
        public void DisplayLink()
        {
            Console.Write("{" + iData + ", " + dData + "} ");
        }
    }//end class Link
}
