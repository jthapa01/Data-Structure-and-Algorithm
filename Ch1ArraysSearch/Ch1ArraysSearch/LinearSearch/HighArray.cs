using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1ArraysSearch
{
    class HighArray
    {
        private int nElemns;
        private long[] arr;

        public HighArray(int size)
        {
            nElemns = 0;
            arr = new long[size];
        }

        public bool Find(int searchKey)
        {
            int i;
            for(i = 0; i<nElemns; i++)      //for each element
            {
                if (arr[i] == searchKey)    //found item?
                {
                    break;              //exit loop before end
                }
            }
            if (i == nElemns)           //gone to end?
            {
                return false;           //Yes can't find it
            }
            else                        //No, found it
            {
                return true;
            }
        }
        public void Insert(long num)        //put elements into array
        {
            arr[nElemns] = num;             //insert it
            nElemns++;                      //insert size
        }
        public bool Delete(long num)
        {
            int i;
            for(i= 0; i< nElemns; i++)      //look for it
            {
                if(arr[i] == num)
                {
                    break;
                }
            }
            if (i == nElemns)               //can't find it
            {
                return false;
            }
            else
            {
                for (int j = i; j < nElemns; j++) //move higher one down
                {
                    arr[j] = arr[j + 1];          //decrement size
                }
                nElemns--;
                return true;
            }

        }
        public void Display()
        {
            for(int k = 0; k<nElemns; k++)
            {
                Console.WriteLine(arr[k]+ " ");
            }
            Console.WriteLine();
        }

    }
}
