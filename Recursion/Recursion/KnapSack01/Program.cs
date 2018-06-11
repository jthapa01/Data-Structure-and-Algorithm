using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapSack01
{
    class Program
    {
        //Given a list of items with values and weights, as well as
        //a max weight, find the maximum value you can generate from 
        //items where the sum of the weights is less than the max

        static void Main(string[] args)
        {
            int[] wt = new int[] {1,2,3};
            int[] values = new int[] {6,10,12 };
            int maxWeight = 5;
            int result = new Program().KnapSack(maxWeight, wt,values);
            Console.WriteLine(result);


            int resultDP = new Program().KnapSackDP(maxWeight, wt, values);
            Console.WriteLine("The max weight of Knapsack using Dynamic "
                + "\nProgramming is: {0}", resultDP);
            Console.ReadKey();
        }

        //using recursion
        public int KnapSack(int w, int[] weights, int[] vals)
        {
            return KnapSack(w, weights, vals, 0);
        }

        private int KnapSack(int w, int[] weights, int[] vals, int i)
        {
            if (i == weights.Length)
            {
                return 0;
            }
            if(w-weights[i] < 0)
            {
                return KnapSack(w, weights, vals, i + 1);
            }
            return Math.Max(KnapSack(w - weights[i], weights, vals, i + 1) + vals[i],
                KnapSack(w, weights, vals, i + 1));
        }

        //using dynamic programming by building bottom up solution
        //(optimal substructure and overlapping subproblems): start
        //with sub problem and build up to the main problem
        /*
         * weights = {1, 2 , 3}
         * values = {6, 10, 12}
         * max weight = 5
         * 
         * 
         * -------------weight----------------
                 0    1    2    3    4    5 
                __   __   __   __   __   __
         *   0 | 0    0    0    0    0    0
         *
         i   1 | 0    6    6    6    6    6
         t
         e   2 | 0    6   16   16   16   16
         m
         *   3 | 0    6   10   16   18   22   
         *   
         Time complexibility O(n*W)
        */

        public int KnapSackDP(int w, int[] weights, int[] vals)
        {
            int[,] cache = new int[weights.Length + 1, w+1];
            for(int i = 1; i <= weights.Length; i++)
            {
                for(int j = 1; j<=w; j++)
                {
                    if (weights[i - 1] > j)
                    {
                        cache[i, j] = cache[i - 1, j];
                    }
                    else
                    {
                        cache[i, j] = Math.Max(
                            cache[i - 1, j],
                                cache[i - 1, j - weights[i - 1]] 
                                + vals[i - 1]);
                    }
                }
            }
            return cache[weights.Length, w];
        }
    }
}
