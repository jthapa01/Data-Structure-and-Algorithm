using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArraySh
    {
        private long[] theArray;    //ref to array theArray
        private int nElems;         //number of data items

        public ArraySh(int max)
        {
            theArray = new long[max];
            nElems = 0;
        }

        public void Insert(long value)
        {
            theArray[nElems++] = value;
        }

        public void Display()       //display array contents
        {
            Console.Write("A=");
            for(int i = 0; i<nElems; i++)
            {
                Console.Write(theArray[i] + " ");   //display it
            }
            Console.WriteLine();
        }

        public void ShellSort()
        {
            int inner, outer;
            long temp;
            int h = 1;
            while(h <= nElems/3)    //find initial value of h
            {
                h = h * 3 + 1;      //(1,4,13,40,121,...)
            }

            while (h > 0)           //decreasing h, until h=1
            {
                for(outer = h; outer < nElems; outer++)
                {
                    temp = theArray[outer];
                    inner = outer;

                    while (inner > h -1 && theArray[inner-h] >= temp)
                    {
                        theArray[inner] = theArray[inner - h];
                        inner -= h;
                    }
                    theArray[inner] = temp;
                }//end for
                h = (h - 1) / 3;        //decrease h
            }//end while(h>0)
        }//end shellsort()


    }
}
