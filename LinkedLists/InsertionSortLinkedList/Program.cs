using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            Link[] linkArray = new Link[size];  //create array of Link
            Random rand = new Random();
            for(int j= 0; j<size; j++)
            {
                int n = rand.Next(99);
                Link newLink = new Link(n);     //make link
                linkArray[j] = newLink;         //put in array
            }

            Console.Write("Unsorted Array: ");
            for(int j = 0; j< size; j++)
            {
                Console.Write(linkArray[j].dData + " ");
            }
            Console.WriteLine();
            SortedList theSortedList = new SortedList(linkArray);
            for (int j = 0; j < size; j++)
            {
                linkArray[j] = theSortedList.Remove();
            }
            Console.Write("Sorted Array: ");
            for(int j = 0; j<size; j++)
            {
                Console.Write(linkArray[j].dData + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
