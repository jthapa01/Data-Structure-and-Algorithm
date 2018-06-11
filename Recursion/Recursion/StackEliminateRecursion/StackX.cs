using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEliminateRecursion
{
    class StackX
    {
        private int maxSize;    //size of the StackX Array
        private Params[] stackArray;
        private int top;        //top of stack;

        public StackX(int s)
        {
            maxSize = s;
            stackArray = new Params[maxSize];   //create array
            top = -1;                           //no items yet
        }

        public void Push(Params p)              //push item on top of stack
        {
            stackArray[++top]= p;               //increment top, insert item
        }

        public Params Pop()                     //take item from the top of the stack
        {
            return stackArray[top--];
        }

        public Params Peek()                    //peek at the top of the stack
        {
            return stackArray[top];
        }
    }
}
