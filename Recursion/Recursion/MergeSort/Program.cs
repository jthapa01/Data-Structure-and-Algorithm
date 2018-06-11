using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSize = 100;
            MArray arr = new MArray(maxSize);
            arr.Insert(64);
            arr.Insert(21);
            arr.Insert(33);
            arr.Insert(70);
            //arr.Insert(12);
            //arr.Insert(85);
            //arr.Insert(44);
            //arr.Insert(3);
            //arr.Insert(99);
            //arr.Insert(0);
            //arr.Insert(108);
            //arr.Insert(36);
            Console.WriteLine("Before MergeSorting");
            arr.Display();
            Console.WriteLine();

            arr.MergeSort();
            Console.WriteLine("\nAfter MergeSorting");
            arr.Display();
            Console.ReadKey();
        }
    }
}
