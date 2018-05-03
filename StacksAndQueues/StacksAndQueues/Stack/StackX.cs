using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Stack
{
    class StackX<T>
    {
        private int maxSize;
        private T[] stackArray;
        private int index;
        
        public StackX(int size)
        {
            this.maxSize = size;
            stackArray = new T[maxSize];
            index = -1;//no items yet
        }

        public void Push(T item)//put item on to the stack
        {
            stackArray[++index] = item;//increment top, insert item
        }

        public T Pop()//take item from the top top of stack
        {
            return stackArray[index--];//decrement item
        }

        public T Peek()//peek at the top of stack
        {
            return stackArray[index];
        }

        public bool IsEmpty()//true if stack is empty
        {
            return (index == -1);
        }

        public bool IsFull()//true if stack is full
        {
            return (index == maxSize - 1);
        }
    }
}
