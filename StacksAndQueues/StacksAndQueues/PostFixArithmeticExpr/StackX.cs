using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.PostFixArithmeticExpr
{
    class StackX
    {
        private int maxSize;
        private int[] stackArray;
        private int top;

        public StackX(int size)
        {
            maxSize = size;
            stackArray = new int[maxSize];
            top = -1;
        }

        public void Push(int element)
        {
            stackArray[++top] = element;
        }

        public int Pop()
        {
            return stackArray[top--];
        }

        public int Peek()
        {
            return stackArray[top];
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            return (top == maxSize-1);
        }

        public int Size()
        {
            return (top + 1);
        }

        public int PeekN(int index)
        {
            return stackArray[index];
        }

        public void DisplayStack(string str)
        {
            Console.Write(str + " Stack (bottom-->top): ");
            for(int j=0; j<Size(); j++)
            {
                Console.Write( PeekN(j)+ ' ' );
            }
            Console.WriteLine("");
        }
    }
}
