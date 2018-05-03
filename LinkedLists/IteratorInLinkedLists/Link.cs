using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorInLinkedLists
{
    //Link
    class Link
    {
        public long dData;          //data item
        public Link next;           //next link in list
        public Link(long dd)        //constructor
        {
            dData = dd;
        }
        public void DisplayLink()
        {
            Console.Write(dData + " ");
        }
    }
}
