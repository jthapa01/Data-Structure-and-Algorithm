using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        private Node root;      //first node of tree
        public Tree()
        {
            root = null;        //no nodes in tree yet
        }
//-----------------------------------------------------------------------------------------------------------
        public Node Find(int key)       //Find node with given key
        {                               //Assumes non empty tree
            Node current = root;        //start at root
            while(current.iData != key) //while no match
            {
                if(key < current.iData) //go left?
                {
                    current = current.leftChild;
                }
                else                    //go right?
                {
                    current = current.rightChild;
                }
                if (current==null)      //if not child
                {
                    return null;        //didnt find it
                }
            }
            return current;             //found it
        }
//-------------------------------------------------------------------------------------------------------------------
        public void Insert(int id, double dd)
        {
            Node newNode = new Node();  //make new node
            newNode.iData = id;         //insert data
            newNode.dData = dd;
            if (root == null)           //no node in root
            {
                root = newNode;
            }
            else
            {
                Node current = root;    //start at root
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.iData) //go left?
                    {
                        current = current.leftChild;
                        if(current == null)     //if end of the line
                        {                       //insert on left
                            parent.leftChild = newNode;
                            return;
                        }//end if go left
                    }
                    else                        //or go right
                    {
                        current = current.rightChild;
                        if(current == null)     //if end of the line
                        {                       //insert on right
                            parent.rightChild = newNode;
                            return;
                        }
                    }//end else go right
                }//end while
            }//end else no root
        }//end insert()
//---------------------------------------------------------------------------------------------------------
         //Start finding the node you want to delete when
         //you have found the node, three cases to consider
            //1. The node to be deleted is a leaf(has no children).
            //2. The node to be deleted has one child
            //3. The node to be deleted has two children
        public bool Delete(int key)                                 //Delete node with given key
        {                                                           //Assumes non-empty list
            Node current = root;
            Node parent = root;
            bool isLeftChild = true;
            while (current.iData !=key)                             //search for node
            {
                parent = current;
                if (key < current.iData)                            //go left?
                {
                    isLeftChild = true;
                    current = current.leftChild;
                }
                else
                {
                    isLeftChild = false;
                    current = current.rightChild;
                }
                if(current == null)                                 //end of the line
                {
                    return false;                                   //didn't find it
                }
            }//end while

            //found node to delete
            //case 1: If no children(leaf) simply delete it
            if (current.leftChild == null &&
                    current.rightChild == null)
            {
                if (current == root)    //if root
                {
                    root = null;        //tree is empty
                }
                else if (isLeftChild)
                {
                    parent.leftChild = null;                        //disconnect
                }
                else                                                //from parent
                {
                    parent.rightChild = null;
                }
            }
            //Case 2a: If no right child, replace with left subtree
            else if (current.rightChild == null)
            {
                //The node to be deleted may be the root
                //in which case it has no parent, replace with
                //the appropriate subtree
                if (current == root)
                {
                    root = current.leftChild;
                }
                else if (isLeftChild)                                //left child of parent
                {
                    parent.leftChild = current.leftChild;
                }
                else                                                 //right child of parent
                {
                    parent.rightChild = current.leftChild;
                }
            }
            //Case 2b: If no left child, replace with right subtree
            else if (current.leftChild==null)
            {
                if(current == root)
                {
                    root = current.rightChild;
                }
                else if (isLeftChild)
                {
                    parent.leftChild = current.rightChild;           //left child of parent
                }
                else                                                 //right child of parent
                {
                    parent.rightChild = current.rightChild;
                }
            }
            //Case 3. The node to be deleted has two children
            else    //two children, so replace with inorder successor
            {
                //get successor of node to delete(current)
                Node successor = GetSuccessor(current);

                //connect parent of current to successor instead
                if(current == root)
                {
                    root = successor;
                }
                else if (isLeftChild)
                {
                    parent.leftChild = successor;
                }
                else
                {
                    parent.rightChild = successor;
                }

                //connect successor to current's left child
                successor.leftChild = current.leftChild;
            }//end else two children
            //(successor cannot have a left child)
            return true;
        }//end delete()
//-----------------------------------------------------------------------------------------------------------
        //returns node with next-highest value after delNode
        //goes to right child, then right child's left descendents
        private Node GetSuccessor(Node delNode)
        {
            Node successorParent = delNode;
            Node successor = delNode;
            Node current = delNode.rightChild;                          //go to right child
            while (current != null)                                     //until no more
            {                                                           //left children
                successorParent = successor;
                successor = current;
                current = current.leftChild;                            //go to left child
            }
            if (successor != delNode.rightChild)                        //if sucessor not                                                 
            {                                                           //right child,
                successorParent.leftChild = successor.rightChild;       //make connections
                successor.rightChild = delNode.rightChild;              //new successor position
            }                                                           //(at the deleted node position)
            return successor;
        }
//-------------------------------------------------------------------------------------------------------------
        public void Traverse(int traverseType)
        {
            switch (traverseType)
            {
                case 1:
                    Console.Write("\nPreorder traversal: ");
                    PreOrder(root);
                    break;
                case 2:
                    Console.Write("\nInorder traversal: ");
                    InOrder(root);
                    break;
                case 3:
                    Console.Write("\nPostorder traversal: ");
                    PostOrder(root);
                    break;
            }
            Console.WriteLine();
        }
//--------------------------------------------------------------------------------------------------------------
        private void PreOrder(Node localRoot)
        {
            if(localRoot != null)
            {
                Console.Write(localRoot.iData + " ");
                PreOrder(localRoot.leftChild);
                PreOrder(localRoot.rightChild);
            }
        }
//--------------------------------------------------------------------------------------------------------------
        private void InOrder(Node localRoot)
        {
            if(localRoot != null)
            {
                InOrder(localRoot.leftChild);
                Console.Write(localRoot.iData + " ");
                InOrder(localRoot.rightChild);
            }
        }
//--------------------------------------------------------------------------------------------------------------
        private void PostOrder(Node localRoot)
        {
            if (localRoot != null)
            {
                PostOrder(localRoot.leftChild);
                PostOrder(localRoot.rightChild);
                Console.Write(localRoot.iData + " ");
            }
        }
//--------------------------------------------------------------------------------------------------------------
        public void DisplayTree()
        {
            Stack globalStack = new Stack();
            globalStack.Push(root);
            int nBlanks = 32;
            bool isRowEmpty = false;
            Console.WriteLine("........................................................................");
            while (!isRowEmpty)
            {
                Stack localStack = new Stack();
                isRowEmpty = true;
                for(int j=0; j<nBlanks; j++)
                {
                    Console.Write(' ');
                }
                while (globalStack.Count !=0)
                {
                    Node temp = (Node)globalStack.Pop();
                    if(temp != null)
                    {
                        Console.Write(temp.iData);
                        localStack.Push(temp.leftChild);
                        localStack.Push(temp.rightChild);
                        if(temp.leftChild != null
                            ||temp.rightChild != null)
                        {
                            isRowEmpty = false;
                        }
                    }
                    else
                    {
                        Console.Write("--");
                        localStack.Push(null);
                        localStack.Push(null);
                    }
                    for(int j=0; j<nBlanks*2 - 2; j++)
                    {
                        Console.Write(' ');
                    }
                }//end while globalstack not empty
                Console.WriteLine();
                nBlanks /= 2;
                while(localStack.Count != 0)
                {
                    globalStack.Push(localStack.Pop());
                }
            }//end while isRowEmpty is false
            Console.WriteLine("........................................................................");

        }//end DisplayTree()
    }
}
