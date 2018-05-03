using BinarySearch.BinarySearch;
using BinarySearch.StoringObject;
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
            //Right aligned triangle pattern
            for(int i = 1; i<=5;i++)
            {
                for(int j =1; j <= 5; j++)
                {
                    if (i >5 - j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //Test Binary Search operation:
            int maxSize = 100;
            OrdArray arrTest = new OrdArray(maxSize);
            arrTest.Insert(77);
            arrTest.Insert(99);
            arrTest.Insert(44);
            arrTest.Insert(55);
            arrTest.Insert(22);
            arrTest.Insert(88);
            arrTest.Insert(11);
            arrTest.Insert(00);
            arrTest.Insert(66);
            arrTest.Insert(33);

            int searchKey = 55;     //search for item
            if(arrTest.Find(searchKey) != arrTest.Size())
            {
                Console.WriteLine("Found " + searchKey);
            }
            else
            {
                Console.WriteLine("Can't find "+ searchKey);
            }

            arrTest.Display();      //display items

            arrTest.Delete(00);     //delete 3 items
            arrTest.Delete(55);
            arrTest.Delete(99);

            arrTest.Display();      //display items again


            //Test Person Class
            Console.WriteLine();
            StoringObject.ClassDataArray arr;       //reference to array
            arr = new StoringObject.ClassDataArray(maxSize);
            arr.Insert("Evans", "Patty", 24);
            arr.Insert("Smith", "Lorraine", 37);
            arr.Insert("Yee", "Tom", 43);
            arr.Insert("Adams", "Henry", 63);
            arr.Insert("Hashimoto", "Sato", 21);
            arr.Insert("Stimson", "Henry", 29);
            arr.Insert("Velasquez", "Jose", 72);
            arr.Insert("Lamarque", "Henry", 54);
            arr.Insert("Vang", "Minh", 22);
            arr.Insert("Creswell", "Lucinda", 18);

            arr.DisplayA();     //display items

            Person found;
            String searchName = "Stimson";           //search for item
            found = arr.Find(searchName);

            if(found != null)
            {
                Console.Write("Found ");
                found.DisplayPerson();
            }
            else
            {
                Console.WriteLine("Can't find "+ searchKey);
            }
            Console.WriteLine();
            Console.WriteLine("Deleting Smith, Yee, and Creswell");
            arr.Delete("Smith");
            arr.Delete("Yee");
            arr.Delete("Creswell");

            arr.DisplayA();
            Console.ReadLine();
        }//end main
    }
}
