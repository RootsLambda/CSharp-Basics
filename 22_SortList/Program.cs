// File sortedlist.cs
// Operations with sorted list data structure

/*-----------Note--------------*/
// 1. Sorted List combine with ArrayList with Hash Table
// 2. Add(): Add a key and value pair to the SortedList.

using System;
using System.Collections;

namespace SortList {
    class Program {  // 
        static void Main(string[] args) {
            SortedList MySL= new SortedList();
            
            SortedList MySL2= new SortedList(5);

            SortedList MySL3= new SortedList(MySL2);

            SortedList MySL4 =new SortedList(new PersonComparer());

            MySL4.Add(new Person("Lambda",10), 29);

            MySL4.Add(new Person("Roots",48), 59);


        }
    }
    class PersonComparer:IComparer
    {
        public int Compare(object x, object y) {
            Person p1=x as Person;
            Person p2=y as Person;

            if (p1==null||p2==null)
            {
                throw new InvalidOperationException();
            }
            else{
                if (p1.Age<p2.Age) 
                {
                    return 1;
                }
                else if (p1.Age==p2.Age) {
                    return 0;
                }
                else 
                {
                    return -1;
                }
            }
        }

    }
}
