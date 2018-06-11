using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class TriangularNum
    {
        static void Main(string[] args)
        {
            //Calculate triangular number
            Console.Write("Enter a number: ");
            int num = GetNumber();
            int sumTriangle = Triangle(num);
            Console.WriteLine($"Triangle = {sumTriangle}");

            //Calculate factorical of any given number
            Console.Write("\nEnter a number to calculate factorial: ");
            int fac = GetNumber();
            int factorialResult = Factorial(fac);
            Console.WriteLine($"Factorial of a {fac} is: {factorialResult}");


            Console.ReadLine();
        }

        private static int Factorial(int n)
        {
            if(n == 0)      //base case
            {
                return 1;
            }
            return n * Factorial(n - 1);        //recursive call
        }

        private static int Triangle(int num)
        {
            Console.WriteLine("Entering: num=" + num);  //test
            if (num == 1)
            {
                Console.WriteLine("Returning 1");
                return 1;
            }
            else
            {
                int temp = num + Triangle(num - 1);
                Console.WriteLine("Returning " + temp);
                return temp;
            }
            //return (num + Triangle(num - 1));
        }

        private static int GetNumber()
        {
            String str = GetString();
            return Int32.Parse(str);
        }

        private static string GetString()
        {
            return Console.ReadLine();
        }
    }
}
