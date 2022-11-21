// File arraylist.cs
// Manipulating the Array List data structure

/*-----------Note--------------*/
// 1. Declare the library System.Collection to retrieve ArrayList
// 2. Add(): Add Value object to the end of ArrayList
// 3. To sort multiple objects of an arraylist, we need to define the Sort class differently

using System;
using System.Collections; 
namespace ArrayListExample {
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList MyArray= new ArrayList();

            ArrayList MyArray2=new ArrayList(5);

            ArrayList MyArray3=new ArrayList(MyArray2); 
            
            ArrayList arrpersons= new ArrayList();

            arrpersons.Add(new Person("Lambda",17));
            arrpersons.Add(new Person("Roots",45));
            arrpersons.Add(new Person("Gana",35));

            Console.WriteLine("Original list:");
            foreach(Person item in arrpersons) 
            {
                Console.WriteLine(item.ToString());
            }

           arrpersons.Sort(new SortPersons());
           Console.WriteLine("List sorted by age:");
           foreach(Person item in arrpersons) 
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
    public class SortPersons:IComparer
    {
        public int Compare(object x, object y) {
            // Forcing the type of 2 objects passed to Person.
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

