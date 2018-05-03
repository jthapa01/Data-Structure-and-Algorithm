using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedLists
{
    class Link
    {
        public long dData;
        public Link next;
        public Link previous;
        public Link(long d)
        {
            dData = d;

        }
        public void DisplayLink()
        {
            Console.Write(dData + " ");
        }
    }
}
