using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSize = 100;
            BinarySrchOrdArr binArr = new BinarySrchOrdArr(maxSize);
            binArr.Insert(120);
            binArr.Insert(90);
            binArr.Insert(45);
            binArr.Insert(126);
            binArr.Insert(54);
            binArr.Insert(99);
            binArr.Insert(144);
            binArr.Insert(27);
            binArr.Insert(135);
            binArr.Insert(81);
            binArr.Insert(18);
            binArr.Insert(108);
            binArr.Insert(9);
            binArr.Insert(117);
            binArr.Insert(63);
            binArr.Insert(36);

            binArr.Display();

            int searchKey = 27;
            if(binArr.Find(searchKey) != binArr.Size())
            {
                Console.WriteLine("Found " + searchKey);
            }
            else
            {
                Console.WriteLine("Can't find " + searchKey);
            }
            Console.ReadLine();
            
        }
    }
}
