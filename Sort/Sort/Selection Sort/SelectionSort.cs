using System;
using System.Collections.Generic;
using System.Text;

namespace Sort.Selection_Sort
{
    class SelectionSort
    {
        private int[] arr;
        int index;
        public SelectionSort(int size)
        {
            arr = new int [size];
            index = 0;
        }

        public void Insert(int element)
        {
            arr[index] = element;
            index++;
        }

        public void Display()
        {
            foreach (int elems in arr)
            {
                Console.Write(elems + " ");
            }
            Console.WriteLine();
        }

        public void SelectionSortAlgo()
        {
            int i, j, min, temp;
            for(i = 0; i<index; i++)
            {
                for(j=i; j<index-1; j++)
                {
                    min = arr[i];//min will be the 
                    if (min > arr[j + 1])
                    {
                        temp = min;
                        arr[i] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
