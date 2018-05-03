using StacksAndQueues.Stack;
using StacksAndQueues.Queue;
using StacksAndQueues.PriorityQueue;
using System;
using StacksAndQueues.InfixToPostFix;
using StacksAndQueues.PostFixArithmeticExpr;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Commented out to test
    /*
            //Integer Checker
            StackX<int> theStack = new StackX<int>(10);
            theStack.Push(20);
            theStack.Push(40);
            theStack.Push(60);
            theStack.Push(80);

            while (!theStack.IsEmpty())
            {
                long value = theStack.Pop();
                Console.Write(value + " ");
            }

            //String Checker
            string input, output;
            bool check = false;
            while (!check)
            {
                Console.WriteLine("\nEnter a string: ");
                input = GetString();
                if (input.Equals(""))
                    break;
                Reverser theReverser = new Reverser(input);
                output = theReverser.ReverseTheString();
                Console.WriteLine("Reversed : " + output);
                check = true;
            }

            //Expression Check
            string inStrExpr;
            bool tested = false;
            while (!tested)
            {
                Console.WriteLine("\nEnter a Expression String: ");
                inStrExpr = GetString();
                if (inStrExpr.Equals(""))
                    break;
                BracketChecker bracketChecker = new BracketChecker(inStrExpr);
                bracketChecker.Check();
                tested = true;
            }

            //Queue
            QueueX theQueue = new QueueX(5);
            theQueue.Insert(10);
            theQueue.Insert(20);
            theQueue.Insert(30);
            theQueue.Insert(40);

            theQueue.Remove();
            theQueue.Remove();
            theQueue.Remove();

            theQueue.Insert(50);
            theQueue.Insert(60);
            theQueue.Insert(70);
            theQueue.Insert(80);

            while (!theQueue.IsEmpty())
            {
                long n = theQueue.Remove();
                Console.Write(n + " ");

            }

            //Priority Queue\
            Console.WriteLine();          
            PriorityQ thePQ = new PriorityQ(5);
            thePQ.Insert(30);
            thePQ.Insert(50);
            thePQ.Insert(10);
            thePQ.Insert(40);
            thePQ.Insert(20);

            while (!thePQ.IsEmpty())
            {
                long item = thePQ.Remove();
                Console.WriteLine(item + " "); //10,20,30,40,50

            }//end while


            //InFixToPostFix
            string input1, output1;
            bool test = false;
            while (!test)
            {
                Console.WriteLine("Enter infix: ");
                //Console.Clear();
                input1 = GetStringForInToPost();
                if (input1.Equals(""))
                {
                    break;
                }
                InToPostFix theTrans = new InToPostFix(input1);
                output1 = theTrans.DoTrans();   //do the translation
                Console.Write("Postfix is "+ output1 + '\n');
                test = true;
            }//end while
    */
            //postFix Expression
            string inputTest;
            int outputTest;

            while (true)
            {
                Console.Write("Enter postfix: ");
                inputTest = GetStringForpostFixExpr();
                if (inputTest.Equals(""))   //quit if Enter
                {
                    break;
                }

                ParsePost aParser = new ParsePost(inputTest);
                outputTest = aParser.DoParse();  //do evaluation
                Console.WriteLine("Evaluates to " + outputTest);
            }//end while

            Console.ReadLine();

        }

        private static string GetStringForpostFixExpr()
        {
            return Console.ReadLine();
        }

        private static string GetStringForInToPost()
        {
            String s = Console.ReadLine();
            return s;
        }

        public static String GetString()
        {
            return Console.ReadLine();
        }


    }
}
