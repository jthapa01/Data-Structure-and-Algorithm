using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Stack
{
    /// <summary>
    /// stacks use to check the matching brackets 
    /// in expression
    /// </summary>
    class BracketChecker
    {
        private string input;
        public BracketChecker(string expr)
        {
            this.input = expr;
        }
        public void Check()
        {
            int stackSize = input.Length;//get maximum stack size
            StackX<char> theStack = new StackX<char>(stackSize);
            for (int j = 0; j<input.Length; j++)
            {
                char ch = input[j];//get char
                switch (ch)
                {
                    case '{'://Opening Symbols
                    case '[':
                    case '(':
                        theStack.Push(ch);//push them
                        break;
                    case '}'://closing symbols
                    case ']':
                    case ')':
                        if (!theStack.IsEmpty())
                        {
                            char chx = theStack.Pop();//pop and check
                            if((ch=='}' && chx!='{')||
                                ch==']' && chx!= '['||
                                ch == ')' && chx!= '(')
                            {
                                Console.WriteLine("Error: " +ch+ " at "+j);
                            }
                        }
                        else  //prematurely empty
                        {
                            Console.WriteLine("Error: " + ch + " at " + j);
                        }
                        break;
                    default://no action on other characters
                        break;
                }//end switch
            }//end for
            //at this point, all characters have been processed
            if (!theStack.IsEmpty()) 
            {
                Console.WriteLine("Error: missing right delimeter");
            }

        }//end check
    }
}
