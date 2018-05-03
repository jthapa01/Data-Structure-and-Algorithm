using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Stack
{
    class Reverser
    {
        private string input;
        private string output;

        public Reverser(string str)
        {
            this.input = str;
        }

        public String ReverseTheString()
        {
            int stackSize = input.Length;
            StackX<char> theStack = new StackX<char>(stackSize);

            for (int j = 0; j < input.Length; j++)
            {
                char ch = input[j];
                theStack.Push(ch);
            }
            output = "";
            while (!theStack.IsEmpty())
            {
                char ch = theStack.Pop();//pop a char
                output = output + ch;//append to output
            }
            return output;
        }
    }
}
