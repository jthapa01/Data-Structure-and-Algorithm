using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Raising a number to a power using recursion
            int x = Power(2,10);
            Console.Write($"The power of x to y is: {x}");
            Console.ReadKey();
        }

        //Raising a number to a power
        public static int Power(int x, int y)
        {
            //The scheme is based on the mathematial equality
            //x^y=(x^2)^y/2
            //This is O(Log(n))
            if (y == 0)
            {
                return 1;
            }
            if(y % 2 == 0)
                return Power(x * x, (y/2));
            else
                return x * Power(x * x, (y/2));
        }

        //The Knapsack problem: Trying to fit items of different weights
        //into a knapsack so that the knapsack ends up with a specified
        //total weight. No need to fit in all the items.
        //public int[] KnapSack(int[] weights, int target)
        //{

        //}
    }
}
