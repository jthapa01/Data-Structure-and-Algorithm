using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.InfixToPostFix
{
    //Stack frame
    class StackX
    {
        private int maxSize;
        private char[] stackArray;
        private int top;
        //----------------------------------------------------------
        public StackX(int s)//Constructor
        {
            maxSize = s;
            stackArray = new char[maxSize];
            top = -1;
        }
        //----------------------------------------------------------
        public void Push(char j) //put item on top of stack
        {
            stackArray[++top] = j;
        }
        //----------------------------------------------------------
        public char Pop()//take item from top of stack
        {
            return stackArray[top--];
        }
        //----------------------------------------------------------
        public char Peek() //See the last item
        {
            return stackArray[top];
        }
        //----------------------------------------------------------
        public bool IsEmpty() //Empty when index is -1
        {
            return (top == -1);
        }
        //----------------------------------------------------------
        public int Size() //size index + 1
        {
            return top + 1;
        }
        //----------------------------------------------------------
        public char PeekN(int n)//return item at index n
        {
            return stackArray[n];
        }
        //----------------------------------------------------------
        public void DisplayStack(String s)
        {
            Console.Write(s);
            Console.Write("Stack (bottom-->top: ");
            for(int j = 0; j<Size(); j++)
            {
                Console.Write( PeekN(j) );
                Console.Write(' ');
            }
            Console.WriteLine("");
        }
    }
}
