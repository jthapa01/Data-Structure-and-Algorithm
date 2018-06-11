using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortInsertionCleanup
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSize = 10;
            ArrayIns arr = new ArrayIns(maxSize);
            Random rand = new Random();
            for(int i=0; i<maxSize; i++)
            {
                long n = rand.Next(100);
                arr.Insert(n);
            }
            arr.Display();
            arr.QuickSort();
            arr.Display();
        }
    }
}
