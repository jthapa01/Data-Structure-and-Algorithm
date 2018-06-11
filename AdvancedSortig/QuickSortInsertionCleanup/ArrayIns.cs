using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortInsertionCleanup
{
    public class ArrayIns
    {
        private long[] arr;
        private int nElems;

        public ArrayIns(int size)
        {
            arr = new long[size];
            nElems = 0;
        }

        public void Insert(long value)
        {
            arr[nElems] = value;
            nElems++;
        }

        public void Display()
        {
            Console.Write("A: ");
            for(int i = 0; i < nElems; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
        }

        public void QuickSort()
        {
            RecQuickSort( 0, nElems-1);
        }

        private void RecQuickSort(int left, int right)
        {
            int size = right - left + 1;
            if (size == 10)
            {
                InsertionSort(left, right);
            }
            else
            {
                long median = Median3Calc(left, right);
                int pivot = FindPivot(left, right, median);
                RecQuickSort(left, pivot - 1);
                RecQuickSort(pivot + 1, right);
            }
        }

        private int FindPivot(int left, int right, long median)
        {
            int leftPtr = left;
            int rightPtr = right - 1;
            while (true)
            {
                while (arr[++leftPtr] < median)
                {
                    ;
                }
                while (arr[--rightPtr] > median)
                {
                    ;
                }
                if (leftPtr >= rightPtr)
                {
                    break;
                }
                else
                {
                    Swap(leftPtr, rightPtr);
                }
            }
            Swap(leftPtr, right-1);
            return leftPtr;
        }

        private void InsertionSort(int left, int right)
        {
            int outer, i;
            for ( i = left+1; i<=right; i++)
            {
                long temp = arr[i];
                outer = i;
                while (outer>left && arr[outer - 1]>=temp)
                {
                    arr[outer] = arr[outer - 1];
                    --outer;
                }
                arr[outer] = temp;
            }
        }

        private long Median3Calc(int left, int right)
        {
            int center = left + right / 2;
            if (arr[left] > arr[center])
            {
                Swap(left, center);
            }
            if(arr[left] > arr[right])
            {
                Swap(left, right);
            }
            if (arr[center] > arr[right])
            {
                Swap(center, right);
            }
            arr[right - 1] = arr[center];
            return arr[right - 1];
        }

        private void Swap(int indx1, int indx2)
        {
            long temp = arr[indx1];
            arr[indx2] = temp;
            arr[indx1] = arr[indx2];
        }
    }
}
