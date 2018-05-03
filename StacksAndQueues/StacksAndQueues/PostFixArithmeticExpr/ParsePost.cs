using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.PostFixArithmeticExpr
{
    class ParsePost
    {
        private StackX theStack;
        private string input;

        public ParsePost(string s)
        {
            input = s;
        }

        public int DoParse()
        {
            theStack = new StackX(20);                          //make new stack
            char ch;
            int j;
            int num1, num2, interAns;

            for (j = 0; j < input.Length; j++)
            {
                ch = input[j];
                theStack.DisplayStack("" + ch + " ");           //diagnostic
                if (ch >= '0' && ch <= '9')                     //if it is a number
                {
                    theStack.Push((int)(ch - '0'));             //push it 
                }
                else                                            //its an operator
                {
                    num2 = theStack.Pop();
                    num1 = theStack.Pop();
                    switch (ch)
                    {
                        case '+':
                            interAns = num1 + num2;
                            break;
                        case '-':
                            interAns = num1 - num2;
                            break;
                        case '*':
                            interAns = num1 * num2;
                            break;
                        case '/':
                            interAns = num1 / num2;
                            break;
                        default:
                            interAns = 0;
                            break;
                    }
                    theStack.Push(interAns);                    //push result into stack
                }//end else
            }//end for
            interAns = theStack.Pop();                          //get answer
            return interAns;
        }//end DoParse()
    }//end class ParsePost
}
