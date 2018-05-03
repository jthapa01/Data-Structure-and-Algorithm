using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class AnagramRecursion
    {
        static int size;
        static int count;
        static char[] arrChar = new char[100];

        static void Main()
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            size = input.Length;
            count = 0;
            for(int i=0; i<size; i++)
            {
                arrChar[i] = input[i];
            }
            DoAnagram(size);
            Console.ReadKey();
        }

        private static void DoAnagram(int newSize)
        {
            if(newSize == 1)                    //if too small
            {
                return;                         //go no further
            }
            for(int j=0; j< newSize; j++)       //for each position
            {
                DoAnagram(newSize - 1);         //anagram remaining 
                if (newSize == 2)               //if innermost
                {
                    DisplayWord();              //display it
                }
                Rotate(newSize);                //Rotate word
            }
        }

        private static void Rotate(int newSize)
        {
            int j;
            int position = size - newSize;
            char temp = arrChar[position];      //save the first letter
            for(j=position+1; j < size; j++)    //shift others left
            {
                arrChar[j - 1] = arrChar[j];
            }
            arrChar[j - 1] = temp;              //put first on right
        }

        private static void DisplayWord()
        {
            if (count < 99)
            {
                Console.Write(" ");
            }
            if(count < 9)
            {
                Console.Write(" ");
            }
            Console.Write(++count + " ");
            for(int j = 0; j<size; j++)
            {
                Console.Write(arrChar[j]);
            }
            Console.Write(" ");
            if (count % 6 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
