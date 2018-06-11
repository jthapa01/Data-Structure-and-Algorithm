using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEliminateRecursion
{
    class Program
    {
        static int theNumber;
        static int theAnswer;
        static StackX theStack;
        static int codePart;
        static Params theseParams;



        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            theNumber = GetInt();
            RecTriangle();
            Console.WriteLine("Triangle = " + theAnswer);
            Console.ReadLine();
        }

        public static void RecTriangle()
        {
            theStack = new StackX(10000);
            codePart = 1;
            while (Step() == false) //call step() until it is true
            {
                ;
            }
        }

        public static bool Step()
        {
            switch(codePart)
            {
                case 1:             //initial entry
                    theseParams = new Params(theNumber, 6);
                    theStack.Push(theseParams);
                    codePart = 2;
                    break;
                case 2:             //method entry
                    theseParams = theStack.Peek();
                    if(theseParams.n == 1)
                    {
                        theAnswer = 1;
                        codePart = 5;   //exit
                    }
                    else
                    {
                        codePart = 3;  //recursive call
                    }
                    break;
                case 3:
                    Params newParams = new Params(theseParams.n - 1, 4);
                    theStack.Push(newParams);
                    codePart = 2;     //go enter metod
                    break;
                case 4:
                    theseParams = theStack.Peek();
                    theAnswer = theAnswer + theseParams.n;
                    codePart = 5;
                    break;
                case 5:
                    theseParams = theStack.Peek();
                    codePart = theseParams.returnAddress;   //4 or 6
                    theStack.Pop();
                    break;
                case 6:
                    return true;
            }
            return false;
        }

        public static string GetString()
        {
            string s = Console.ReadLine();
            return s;
        }

        public static int GetInt()
        {
            String s = GetString();
            return Int32.Parse(s);
        }
    }
}
