using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLinkedList
{
    class Link
    {
        public Link next;
        public long dData;
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
