using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedList
{
    //Represents a link which has a reference 
    //to the next element in a list
    //last element next reference is null
    class Link
    {
        public long dData;
        public Link next;
        public Link(long dd)
        {
            dData = dd;
        }
        public void DisplayLink()
        {
            Console.Write(dData + " ");
        }
    }
}
