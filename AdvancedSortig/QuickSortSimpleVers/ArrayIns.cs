using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortSimpleVers
{
    public class ArrayIns
    {
        private long[] theArray;
        int nElems;

        public ArrayIns(int size)
        {
            theArray = new long[size];
            nElems = 0;
        }

        public void Insert(long val)
        {
            theArray[nElems] = val;
            nElems++;
        }

        public void Display()
        {
            Console.Write("A = ");
            for(int i = 0; i<nElems; i++)
            {
                Console.Write(theArray[i] + " ");
            }
            Console.WriteLine();
        }

        public void QuickSort()
        {
            RecQuickSort(0, nElems-1);
        }

        private void RecQuickSort(int left, int right)
        {
            if (right-left <= 0)        //if size <= 1
            {
                return;                 //already sorted
            }
            else                        //size is 2 or larger
            {
                long pivot = theArray[right];    //rightmost item
                int partition = Partition(left, right, pivot);  //partition range
                RecQuickSort(left, partition - 1);      //sort left side
                RecQuickSort(partition + 1, right);     //sort right side
            }
               
        }

        private int Partition(int left, int right, long pivot)
        {
            int leftPtr = left - 1;
            int rightPtr = right;

            while (true)
            {
                //find bigger item
                while (theArray[++leftPtr] < pivot)
                {
                    ; //nop
                }
                //find smaller item
                while(rightPtr > 0 && theArray[--rightPtr] > pivot)
                {
                    ;//no-op
                }
                //if pointers cross, partition done
                if (leftPtr >= rightPtr)
                {
                    break;
                }
                else  //not crossed, swap elements
                {
                    Swap(leftPtr, rightPtr);
                }
            }
            Swap(leftPtr, right);       //restore pivot
            return leftPtr;             //return pivot location
        }//end partitionIt()

        private void Swap(int dex1, int dex2)
        {
            long temp = theArray[dex1];         //A into temp
            theArray[dex1] = theArray[dex2];    //B into A
            theArray[dex2] = temp;              //temp into B
        }
    }
}
