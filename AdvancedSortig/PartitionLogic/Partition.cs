using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionLogic
{
    public class Partition
    {
        private long[] theArray;
        private int nElemns;

        public Partition(int size)
        {
            theArray = new long[size];
            nElemns = 0;
        }
        public void Insert(long val)
        {
            theArray[nElemns] = val;
            nElemns++;
        }

        public void Display()
        {
            Console.Write("A = ");
            for(int i = 0; i<nElemns; i++)
            {
                Console.Write(theArray[i] + " ");
            }
            Console.WriteLine();
        }

        public int Size()
        {
            return nElemns;
        }

        public int PartitionIt(int left, int right, long pivot)
        {
            int leftPtr = left - 1;         //right of first elem
            int rightPtr = right + 1;       //left of pivot
            while (true)
            {
                while(leftPtr < right && 
                    theArray[++leftPtr] < pivot) //find bigger item
                {
                    ;
                }

                while(rightPtr > left && 
                    theArray[--rightPtr]> pivot)  //find smaller item
                {
                    ;
                }

                if(leftPtr >= rightPtr)  //if pointers cross, partition done
                {
                    break;
                }
                else                     //not crossed swap elements
                {
                    Swap(leftPtr, rightPtr);
                }
            }
            return leftPtr;             //return partition

        }

        private void Swap(int dex1, int dex2)
        {
            long temp;
            temp = theArray[dex1];            //A into temp
            theArray[dex1] = theArray[dex2];  //B into A
            theArray[dex2] = temp;            //temp into B
        }
    }
}
