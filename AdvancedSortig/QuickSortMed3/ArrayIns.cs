using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortMed3
{
    class ArrayIns
    {
        private long[] theArray;
        private int nElems;
        public ArrayIns(int max)
        {
            theArray = new long[max];
            nElems = 0;
        }

        public void Insert(long value)
        {
            theArray[nElems] = value;
            nElems++;
        }

        public void Display()
        {
            Console.Write("A = ");
            for(int j = 0; j<nElems; j++)
            {
                Console.Write(theArray[j] + " ");
            }
            Console.WriteLine();
        }

        public void QuickSort()
        {
            RecQuickSort(0, nElems - 1);
        }

        private void RecQuickSort(int left, int right)
        {
            int size = right - left + 1;
            if(size <= 3)       //manual sort if small
            {
                ManualSort(left, right);    
            }
            else        //quicksort if large
            {
                long median = MedianOf3(left, right);
                int partition = PartitionIt(left, right, median);
                RecQuickSort(left, partition - 1);
                RecQuickSort(partition + 1, right);
            }
        }

        private int PartitionIt(int left, int right, long pivot)
        {
            int leftPtr = left;       //righ o fforst elem  
            int rightPtr = right - 1; //left of pivot
            while (true)
            {
                while (theArray[++leftPtr] < pivot)    //find bigger
                {
                    ;
                }
                while(theArray[--rightPtr]>pivot)       //find smaller
                {
                    ;
                }
                if(leftPtr >= rightPtr)             //if pointers cross
                {                                   //partition done
                    break;
                }
                else                                //not crossed, so
                {                                   //swap elements
                    Swap(leftPtr, rightPtr);        //swap elements
                }
            }//end while(true)
            Swap(leftPtr, right - 1);
            return leftPtr;
        }//end PartitionIt()

        private long MedianOf3(int left, int right)
        {
            int center = (left+right)/2;
            //order left and center
            if (theArray[left] > theArray[center])
            {
                Swap(left, center);
            }
            //order left and right
            if (theArray[left] > theArray[right])
            {
                Swap(left, right);
            }
            //order center and right
            if (theArray[center] > theArray[right])
            {
                Swap(center, right);
            }
            Swap(center, right-1);      //put pivot on right
            return theArray[right - 1]; //return median value

        }

        private void Swap(int dex1, int dex2)
        {
            long temp = theArray[dex1];         //A into temp
            theArray[dex1] = theArray[dex2];    //B into A
            theArray[dex2] = temp;              //temp into B
        }//end Swap

        private void ManualSort(int left, int right)
        {
            int size = right - left + 1;
            if(size <= 1)
            {
                return;                 //no sort necessary
            }
            if (size == 2)
            {                           //2-sort left and right
                if (theArray[left] > theArray[right])
                {
                    Swap(left, right);
                }
                return;
            }
            else            //size is 3
            {               //3-sort left, center and right
                if (theArray[left] > theArray[right - 1])
                {
                    Swap(left, right - 1);      //left, center
                }
                if (theArray[left] > theArray[right])
                {
                    Swap(left, right);          //left, right
                }
                if(theArray[right-1]> theArray[right])
                {
                    Swap(right - 1, right);     //center, right
                }
            }
        }//end ManualSort()
    }
}
