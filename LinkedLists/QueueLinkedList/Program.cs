using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkQueue theQueue = new LinkQueue();
            theQueue.Insert(20);
            theQueue.Insert(40);

            theQueue.DisplayQueue();

            theQueue.Insert(60);
            theQueue.Insert(80);

            theQueue.DisplayQueue();
            theQueue.Remove();
            theQueue.Remove();

            theQueue.DisplayQueue();
            Console.ReadLine();
        }
    }
}
