using System;
using System.Collections.Generic;
using System.Text;

namespace Sort.Insertion_Sort
{
    class InsertionSort
    {
        private int[] arr;
        private int numElems;

        public InsertionSort(int len)
        {
            this.arr = new int[len];
            this.numElems = 0;
        }

        public void Insert(int elem)
        {
            arr[numElems] = elem;
            numElems++;
        }

        public void Display()
        {
            foreach(int nums in arr)
            {
                Console.Write(nums + " ");
            }
            Console.WriteLine();
        }

        public void InsertionSortAlgo()
        {
            int outer, inner;
            for(outer = 1; outer<numElems; outer++)//out is dividing line
            {
                int temp = arr[outer];//removed marked item
                inner = outer;//start shifts at out
                while (inner>0 && arr[inner - 1] >= temp)//until one is smaller
                {
                    arr[inner] = arr[inner - 1];//shift item right
                    inner--;//go left one position
                }
                arr[inner] = temp;//insert marked item
            }
        }
    }


}
