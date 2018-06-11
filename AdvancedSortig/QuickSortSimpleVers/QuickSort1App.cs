using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortSimpleVers
{
    class QuickSort1App
    {
        static void Main(string[] args)
        {
            int maxSize = 16;
            ArrayIns arr = new ArrayIns(maxSize);
            Random rand = new Random();
            for(int j= 0; j<maxSize; j++)
            {
                long n = rand.Next(99);
                arr.Insert(n);
            }
            arr.Display();
            arr.QuickSort();
            arr.Display();

        }
    }
}
