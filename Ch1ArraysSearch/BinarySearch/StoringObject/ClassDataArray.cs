using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.StoringObject
{
    public class ClassDataArray
    {
        private Person[] a;         //reference to array
        private int nElemns;        //number of data items

        public ClassDataArray(int max)
        {
            a = new Person[max];    //create the array
            nElemns = 0;            //no item yet
        }

        public Person Find(string searchName)
        {
            int j;
            for(j=0; j<nElemns; j++)
            {                       //find specified value
                if (a[j].GetLast().Equals(searchName))   //found item?
                    break;                               //exit loop before end 
            }
            if (j == nElemns)                            //go to end?
            {
                return null;                             //yes, can't find it 
            }
            else
            {
                return a[j];                            //no, found it
            }
        }
        //put person into array
        public void Insert(string last, string first, int age)
        {
            a[nElemns] = new Person(last, first, age);
            nElemns++;      //increment size
        }

        public bool Delete(string searchName)
        {
            int j;
            for(j=0; j<nElemns; j++)
            {
                if (a[j].GetLast().Equals(searchName))
                {
                    break;
                }
            }
            if (j==nElemns)     //can't find it
            {
                return false;
            }
            else
            {
                for(int i=j; i<nElemns; i++)
                {
                    a[i] = a[i + 1];
                }
                nElemns--;
                return true;
            }
        }

        public void DisplayA()
        {
            for(int i=0; i<nElemns; i++)
            {
                a[i].DisplayPerson();
            }
        }
    }
}
