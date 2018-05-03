using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleEndedLists
{
    //A double ended lst is similar to an ordinary list, 
    //but it has one additinal feature: a reference to
    // last link as well to the first
    class Link
    {
        public long dData;
        public Link next;

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
