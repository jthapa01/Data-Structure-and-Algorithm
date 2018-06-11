using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEliminateRecursion
{
    /* When a method is called, its arguments and the 
     * return address are pushed on to the stack.
     * A method can access its arguments by peeking at
     * the top of the stack
     * When a method is about to return, it peeks at the 
     * stack to obtain the return address and then pops both
     * address and its agruments off the stack & discard them.
     */
     
    //parameters to save on stack
    class Params
    {
        public int n;
        public int returnAddress;

        public Params(int nn, int ra)
        {
            n = nn;
            returnAddress = ra;
        }
    }
}
