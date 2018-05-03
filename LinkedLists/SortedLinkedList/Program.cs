using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList theSortedList = new SortedList();
            theSortedList.Insert(20);
            theSortedList.Insert(40);

            theSortedList.DisplayList();
            theSortedList.Insert(10);
            theSortedList.Insert(30);
            theSortedList.Insert(50);

            theSortedList.DisplayList();
            Console.ReadKey();
        }
    }
}
