using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedList
{
    class LinkStack
    {
        private LinkList theList;
        public LinkStack()
        {
            theList = new LinkList();
        }
        public void Push(long j)
        {
            theList.InsertFirst(j);
        }
        public void Pop()
        {
            theList.DeleteFirst();
        }
        public bool IsEmpty()
        {
            return theList.IsEmpty();
        }
        public void DisplayStack()
        {
            Console.Write("Stack (top-->bottom): ");
            theList.DisplayList();
        }
    }
}
