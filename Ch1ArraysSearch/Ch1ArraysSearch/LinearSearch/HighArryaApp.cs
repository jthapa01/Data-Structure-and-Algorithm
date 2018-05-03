using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1ArraysSearch
{
    class HighArryaApp
    {
        public static void Main()
        {
            int size = 100;
            HighArray highArray = new HighArray(size);
            highArray.Insert(77);
            highArray.Insert(99);
            highArray.Insert(44);
            highArray.Insert(55);
            highArray.Insert(22);
            highArray.Insert(88);
            highArray.Insert(11);
            highArray.Insert(00);
            highArray.Insert(66);
            highArray.Insert(33);

            highArray.Display();        //display items

            int searchKey = 35;         //search for item
            if (highArray.Find(searchKey))
            {
                Console.WriteLine("Found " + searchKey);
            }
            else
            {
                Console.WriteLine("Can't Find " + searchKey);
            }

            highArray.Delete(00);
            highArray.Delete(55);
            highArray.Delete(99);

            highArray.Display();
            Console.ReadLine();

        }



    }
}
