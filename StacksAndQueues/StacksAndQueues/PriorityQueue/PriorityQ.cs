using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.PriorityQueue
{
    class PriorityQ
    {
        //array in sorted order, from max at 0 to min at size-1
        private int maxSize;
        private long[] queArray;
        private int nItems;

        public PriorityQ(int s)//Constructor
        {
            maxSize = s;
            queArray = new long[maxSize];
            nItems = 0;
        }

        public void Insert(long item)
        {
            int j;
            if (nItems == 0)
            {
                queArray[nItems++] = item;//if no items insert at 0
            }
            else //if items
            {
                for(j = nItems-1; j>=0; j--) //start at end
                {
                    if (item > queArray[j])  //if new item larger
                    {
                        queArray[j + 1] = queArray[j]; //shift upward
                    }
                    else //if smaller
                    {
                        break;
                    }
                }//end for
                queArray[j + 1] = item; //insert it
                nItems++;
            }//end else (nItem >0)

        }//end insert()

        public long Remove()  //remove minimum item
        {
            return queArray[--nItems];
        }
        public long PeekMin() //peek at minimum item
        {
            return queArray[nItems-1];
        }

        public bool IsEmpty()  //true if queue is empty
        {
            return (nItems == 0);
        }

        public bool IsFull()  //true if queue is fool
        {
            return (nItems == maxSize);
        }
    }
}//end class PriorityQ
