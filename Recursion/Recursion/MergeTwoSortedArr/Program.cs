using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = { 23, 47, 81, 95 };
            int[] arrayb = new int[] {7, 14, 39, 55, 62, 74 };
            int[] arrayC = new int[10];
            Merge(arrayA, arrayA.Length, arrayb, arrayb.Length, arrayC);
            Display(arrayC, arrayC.Length);
            Console.ReadKey();
        }

        public static void Merge(int[] arrA, int sizeA, int[] arrB, 
                                        int sizeB, int[] arrC)
        {
            int indxA=0, indxB=0, indxC = 0;
            while (indxA <sizeA && indxB < sizeB)       //neither array empty
            {
                if (arrA[indxA] < arrB[indxB])          //array A smaller
                {
                    arrC[indxC++] = arrA[indxA++];
                }
                else
                {
                    arrC[indxC++] = arrB[indxB++];
                }
            }
            while (indxA < sizeA)                        //arrB is empty
            {                                            //arrayA is not
                arrC[indxC++] = arrA[indxA++];
            }
            
            while(indxB < sizeB)                         //arrA is empty
            {                                            //ArrB is not
                arrC[indxC++] = arrB[indxB++];
            }

        }

        public static void Display(int[] theArr, int size)
        {
            Console.WriteLine("The merge sorted array is: ");
            for(int i = 0; i< size; i ++)
            {
                Console.Write(theArr[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
