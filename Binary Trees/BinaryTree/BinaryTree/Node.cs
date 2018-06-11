using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public int iData;       //data item (key)
        public double dData;    //data item
        public Node leftChild;  //this node's left child
        public Node rightChild; //this node's right child
//------------------------------------------------------------------
        public void DisplayNode()
        {
            Console.Write('{');
            Console.Write(iData);
            Console.Write(", ");
            Console.Write(dData);
            Console.Write("} ");
        }
    }
}
