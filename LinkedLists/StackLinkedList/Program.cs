using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkStack theStack = new LinkStack();//make stack
            theStack.Push(20);
            theStack.Push(40);

            theStack.DisplayStack();

            theStack.Push(60);
            theStack.Push(80);

            theStack.DisplayStack();

            theStack.Pop();
            theStack.Pop();

            theStack.DisplayStack();


            Console.ReadLine();
        }
    }
}
