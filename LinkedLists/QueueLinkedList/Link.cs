using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedList
{
    class Link
    {
        public long dData;
        public Link next;

        public Link(long elem)
        {
            dData = elem;
        }
        public void DisplayLink()   //display the link
        {
            Console.Write(dData + " ");
        }
    }
}
