using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.InfixToPostFix
{
    //This program doesnt check the input for errors
    class InToPostFix
    {
        private StackX theStack;
        private string input;
        private string output = "";
        //----------------------------------------------------------
        public InToPostFix(string str)//constructor
        {
            input = str;
            int stackSize = input.Length;
            theStack = new StackX(stackSize);
        }
        //----------------------------------------------------------
        public string DoTrans()//do translation to postfix
        {
            for(int j = 0; j<input.Length; j++)
            {
                char ch = input[j];
                theStack.DisplayStack("For " + ch + " ");  //diagnostic
                switch (ch)
                {
                    case '+':
                    case '-':               //it's + or -
                        GotOper(ch, 1);     //go pop operators
                        break;              //(precedence 1)
                    case '*':
                    case '/':               //it's * or /
                        GotOper(ch, 2);     //go pop operators
                        break;              //(precdence 2)
                    case '(':               //it's a left paren
                        theStack.Push(ch);  //push it
                        break;
                    case ')':               //it's a right paren
                        GotParen(ch);       //go pop operators
                        break;
                    default:                //must be an operand
                        output = output + ch;   //write it to output
                        break;
                }//end switch
            }//end for
            while (!theStack.IsEmpty())  //pop remaining opers
            {
                theStack.DisplayStack("While ");     //diagnostic
                output = output + theStack.Pop();   //write to output
            }
            theStack.DisplayStack("End  ");          //diagnostic
            return output;                          //return postfix
        }//end doTrans()

        private void GotParen(char ch)
        {//got right parent from input
            while (!theStack.IsEmpty())
            {
                char chx = theStack.Pop();
                if (chx == '(')                      //if popped '('
                {
                    break;                          //we are done
                }
                else                                //if operator popped
                {
                    output = output + chx;          //output it
                }
            }//end while
        }//end popOps()

        //----------------------------------------------------------
        public void GotOper(char opThis, int prec1)
        {//got operator from input
            while (!theStack.IsEmpty())
            {
                char opTop = theStack.Pop();
                if(opTop=='(')                  //if its a '('
                {
                    theStack.Push(opTop);       //restore '('
                    break;
                }
                else                            //its an operator
                {
                    int prec2;                  //precedence of new op
                    if(opTop=='+' || opTop == '-')  //find new op prec
                    {
                        prec2 = 1;
                    }
                    else
                    {
                        prec2 = 2;
                    }
                    if (prec2<prec1)            //if precedence of new op less
                    {                           //than of teh old 
                        theStack.Push(opTop);   //save newly-popped op
                        break;
                    }
                    else                        //prec of new not less than old precedence
                    {
                        output = output + opTop;
                    }//end else(it's an operator)
                }
                       //push new operator
            }//end while
            theStack.Push(opThis);
        }//end gotOp()
    }


}
