using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySrchOrdArr
    {
        private int[] arr;
        private int nElements;

        public BinarySrchOrdArr(int sizeArr)
        {
            arr = new int[sizeArr];
            nElements = 0;
        }

        public int Size()
        {
            return nElements;
        }

        public int Find(int searchKey)
        {
            return BinaryElemFind(searchKey, 0, nElements-1);
        }

        public int BinaryElemFind(int searchKey, int lowerBound, int upperBound)
        {
            int currPos = (lowerBound + upperBound) / 2;
            if (arr[currPos] == searchKey)
            {
                return arr[currPos];
            }
            else if (lowerBound>upperBound)
            {
                return nElements;
            }
            else
            {
                if (arr[currPos]<searchKey)
                {
                    return BinaryElemFind(searchKey,currPos+1,upperBound);
                }
                else
                {
                    return BinaryElemFind(searchKey,lowerBound, currPos-1);
                }
            }
        }

        public void Insert(int value)
        {
            int i;
            //find the index where the element is  greater than value
            //break out of the loop when found
            for(i=0; i< nElements; i++)
            {
                if(arr[i]> value)
                {
                    break;
                }
            }
            //move bigger elements to the right from last index
            //to make a room for inserting the new val
            for(int j = nElements; j>i; j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[i] = value;
            nElements++;                    //increase index once inserting
        }

        public void Display()
        {
            for (int i =0; i<nElements; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
