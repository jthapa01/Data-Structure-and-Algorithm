using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Queue
{
    class QueueX
    {
        private int maxSize;
        private long[] queArray;
        private int front;
        private int rear;
        private int nItems;

        public QueueX(int size)//Constructor
        {
            maxSize = size;
            queArray = new long[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }

        public void Insert(long j)
        {
            if(rear == maxSize - 1)//deal with wraparound
            {
                rear = -1;
            }
            queArray[++rear] = j;
            nItems++;
        }

        public long Remove()
        {
            long temp = queArray[front++];
            if(front == maxSize)
            {
                front = 0;
            }
            nItems--;//one less item
            return temp;
        }
        public long PeekFront()
        {
            return queArray[front];
        }

        public Boolean IsEmpty()
        {
            return (nItems == 0);
        }
        public Boolean IsFull()
        {
            return (nItems == maxSize);
        }
        public int Size()
        {
            return nItems;
        }
    }

}
