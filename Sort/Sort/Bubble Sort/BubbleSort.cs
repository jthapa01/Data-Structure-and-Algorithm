using System;
using System.Collections.Generic;
using System.Text;

namespace Sort.Bubble_Sort
{
    class BubbleSort
    {
        private int ArraySize;
        int[] numArray;
        int index;

        public BubbleSort(int size)
        {
            this.ArraySize = size;
            this.numArray = new int[size];
            index = 0;
        }

        public void Insert(int num)
        {
            numArray[index] = num;
            index++;
            
        }

        public void Display()
        {
            foreach(int num in numArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public void BubbleSortAlgorith()
        {
            int i, j;//, temp; 
            for(i = numArray.Length -1; i>=0; i--)//outer loop backward
            {
                for(j = 0; j<i; j++)//inner forward
                {
                    if (numArray[j] > numArray[j + 1])//not in order?
                    {
                        //temp = numArray[j];
                        //numArray[j] = numArray[j + 1];
                        //numArray[j + 1] = temp;
                        Swap(j,j+1);//swap them
                    }
                }
            }
        }
        public void Swap(int num1, int num2)
        {
            int temp = numArray[num1];
            numArray[num1] = numArray[num2];
            numArray[num2] = temp;
        }

    }
}
