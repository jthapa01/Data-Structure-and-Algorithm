using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.StoringObject
{
    public class Person
    {
        private string lastName;
        private string firstName;
        private int age;

        public Person(string last, string first, int a)
        {
            lastName = last;
            firstName = first;
            age = a;
        }

        public void DisplayPerson()
        {
            Console.Write(" Last  name: " + lastName);
            Console.Write(", First name: "+ firstName);
            Console.WriteLine(", Age: " + age);
        }

        public string GetLast()
        {
            return lastName;
        }
    }
}
