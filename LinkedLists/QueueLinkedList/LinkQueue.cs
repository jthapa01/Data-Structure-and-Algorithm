using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedList
{
    class LinkQueue
    {
        private FirstLastLast theList;
        public LinkQueue()
        {
            theList = new FirstLastLast(); //make 2-ended list
        }
        public bool IsEmpty()
        {
            return theList.IsEmpty();
        }
        public void Insert(long j)
        {
            theList.InsertLast(j);
        }
        public long Remove()
        {
            return theList.DeleteFirst();
        }
        public void DisplayQueue()
        {
            Console.Write("Queue (front --> rear): ");
            theList.DisplayList();
        }
    }
}
