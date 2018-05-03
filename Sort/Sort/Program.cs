using Sort.Bubble_Sort;
using Sort.Selection_Sort;
using Sort.Insertion_Sort;
using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort(8);

            bubbleSort.Insert(5);
            bubbleSort.Insert(8);
            bubbleSort.Insert(7);
            bubbleSort.Insert(4);
            bubbleSort.Insert(3);
            bubbleSort.Insert(10);
            bubbleSort.Insert(41);
            bubbleSort.Insert(45);

            Console.WriteLine("Before bubble sorting: ");
            bubbleSort.Display();
            //Bubble Sort: The largest value bubbles 
            //towards the right in each pass like a bubble
            //Invariant is that the data items to the right are sorted
            bubbleSort.BubbleSortAlgorith();
            Console.WriteLine("\nAfter bubble sorting: ");
            bubbleSort.Display();

            //Selection Sort
            SelectionSort selecionSort = new SelectionSort(10);

            selecionSort.Insert(77);
            selecionSort.Insert(99);
            selecionSort.Insert(44);
            selecionSort.Insert(55);
            selecionSort.Insert(22);
            selecionSort.Insert(88);
            selecionSort.Insert(11);
            selecionSort.Insert(00);
            selecionSort.Insert(66);
            selecionSort.Insert(33);
            Console.WriteLine("\nBefore Selection sorting: ");
            selecionSort.Display();

            //selecionSort Sort: The minimum value shift to the left in each pass 
            //Every Element will be selected and compared with the min value
            //and replaced if necessary
            selecionSort.SelectionSortAlgo();
            Console.WriteLine("\nAfter Selection sorting: ");
            selecionSort.Display();

             //Selection Sort
            InsertionSort insertionSort = new InsertionSort(10);

            insertionSort.Insert(77);
            insertionSort.Insert(99);
            insertionSort.Insert(44);
            insertionSort.Insert(55);
            insertionSort.Insert(22);
            insertionSort.Insert(88);
            insertionSort.Insert(11);
            insertionSort.Insert(00);
            insertionSort.Insert(66);
            insertionSort.Insert(33);
            Console.WriteLine("\nBefore Insertion sorting: ");
            insertionSort.Display();

            //Insertion Sort: The minimum value shift to the left in each pass 
            //Every Element will be selected and compared with the min value
            //and replaced if necessary
            insertionSort.InsertionSortAlgo();
            Console.WriteLine("\nAfter Selection sorting: ");
            selecionSort.Display();




            Console.ReadLine();

        }
    }
}
