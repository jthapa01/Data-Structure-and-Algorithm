using DoubleEndedLists;
using System;

namespace Double_EndedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstLastList theList = new FirstLastList();
            theList.InsertFirst(22); //Insert at front
            theList.InsertFirst(44);
            theList.InsertFirst(66);

            theList.InsertLast(11); //Insert at Rear
            theList.InsertLast(33);
            theList.InsertLast(55);

            theList.DisplayList();
            theList.DeleteFirst();
            theList.DeleteFirst();
            theList.DisplayList();


            Console.ReadLine();
        }
    }
}
