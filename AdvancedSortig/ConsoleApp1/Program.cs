using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSize = 10;    //array size
            ArraySh arr = new ArraySh(maxSize); //create an array
            Random rand = new Random();
            for(int j = 0;j< maxSize; j++)
            {
                long n = rand.Next(100);
                arr.Insert(n);
            }
            arr.Display();
            arr.ShellSort();
            arr.Display();
        }
    }
}
