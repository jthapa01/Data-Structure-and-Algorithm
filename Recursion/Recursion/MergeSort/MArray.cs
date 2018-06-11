using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MArray
    {
        private int nElements;
        private long[] theArray;

        public MArray(int size)
        {
            theArray = new long[size];
            nElements = 0;
        }

        public void Insert(long val)
        {
            theArray[nElements] = val;
            nElements++;
        }

        public void Display()
        {
            for(int i = 0; i<nElements; i++)
            {
                Console.Write(theArray[i] + " ");
            }
            Console.WriteLine();
        }

        public void MergeSort()
        {
            long[] workSpace = new long[nElements];
            RecMergeSort(workSpace, 0, nElements - 1);
        }

        private void RecMergeSort(long[] workSpace, int lowerBound, int upperBound)
        {
            Console.WriteLine($"Entering {lowerBound}-{upperBound}");
            if (lowerBound == upperBound)
            {
                Console.WriteLine($"Base-Case Return {lowerBound}-{upperBound}");
                return;
            }
            else
            {                                                //find midpoint
                int mid = (lowerBound + upperBound) / 2;
                Console.WriteLine($"Will sort low half of {lowerBound}-{upperBound}");
                RecMergeSort(workSpace, lowerBound, mid);
                RecMergeSort(workSpace, mid+1, upperBound);
                Console.WriteLine($"Will merge halves into {lowerBound}-{upperBound}");
                Merge(workSpace, lowerBound,mid+1, upperBound);
                Console.WriteLine($"Return {lowerBound}-{upperBound}");
            }
        }

        public void Merge(long[] workSpace, int lowPtr,
                                int highPtr, int upperBound)
        {
            int j = 0;
            int lowerBound = lowPtr;
            int mid = highPtr - 1;
            int n = upperBound - lowerBound + 1;

            while (lowPtr<=mid && highPtr <=upperBound)
            {
                if (theArray[lowPtr] < theArray[highPtr])
                {
                    workSpace[j++] = theArray[lowPtr++];
                }
                else
                {
                    workSpace[j++] = theArray[highPtr++];
                }
            }
            while (lowPtr <= mid)
            {
                workSpace[j++] = theArray[lowPtr++];
            }

            while(highPtr <= upperBound)
            {
                workSpace[j++] = theArray[highPtr++];
            }

            for(j=0; j<n; j++)
            {
                theArray[lowerBound + j] = workSpace[j];
            }
        }
    }
}
