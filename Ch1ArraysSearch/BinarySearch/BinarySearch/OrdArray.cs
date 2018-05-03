using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.BinarySearch
{
    public class OrdArray
    {
        private int nElems;
        private int[] arr;

        public OrdArray(int size)
        {
            nElems = 0;
            arr = new int[size];
        }

        public void Insert(int num)     //put elements into array
        {
            int j;
            for( j=0; j<nElems; j++)    //Find where it goes
            {
                if(arr[j]> num)
                {
                    break;
                }
            }
            for(int k= nElems; k > j; k--)
            {
                arr[k] = arr[k - 1];
            }
            arr[j] = num;
            nElems++;
        }

        public bool Delete(int elem)
        {
            int j = Find(elem);
            if (j == nElems)        //can't found it
            {
                return false;
            }
            else
            {
                for (int k = j; k < nElems; k++)    //move bigger ones down
                {
                    arr[k] = arr[k + 1];
                }
                nElems--;
                return true;
            }

        }

        public int Find(long searchKey)
        {
            int lowerBound = 0;
            int upperBound = nElems - 1;
            int currIn;

            while (true)
            {
                currIn = (lowerBound + upperBound) / 2;
                if (arr[currIn] == searchKey)
                {
                    return currIn;                  //found it
                }
                else if(lowerBound > upperBound)
                {
                    return nElems;                  //cant find it
                }
                else
                {
                    if (arr[currIn] < searchKey)
                    {
                        lowerBound = currIn + 1;    //It's in upper half
                    }
                    else                            //divide range
                    {
                        upperBound = currIn - 1;    //It's in lower half
                    }
                }
            }
        }//end Find

        public int Size()
        {
            return nElems;
        }
        public void Display()               //display array contents
        {
            for(int j= 0; j< nElems; j++)   
            {
                Console.Write(arr[j] + " ");
            }
            Console.WriteLine("");
        }
    }
}
