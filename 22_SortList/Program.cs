using System;
using System.Collections;

namespace SortList {
    class Program {  // Ket hop voi ArrayList voi Hash Table
        static void Main(string[] args) {
            SortedList MySL= new SortedList();
            
            SortedList MySL2= new SortedList(5);
            SortedList MySL3= new SortedList(MySL2);

            SortedList MySL4 =new SortedList(new PersonComparer());


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
