using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSize = 16;
            Partition arr = new Partition(maxSize);
            Random rand = new Random();
            for(int j = 0; j<maxSize; j++)
            {
                long n = rand.Next(199);
                arr.Insert(n);
            }
            arr.Display();          //display unsorted array

            long pivot = 99;
            Console.Write("Pivot is " + pivot);
            int size = arr.Size();
            //partition array
            int partDex = arr.PartitionIt(0, size - 1, pivot);
            Console.WriteLine(", Partition is at index "+ partDex);
            arr.Display();          //display partition array
        }
    }
}
