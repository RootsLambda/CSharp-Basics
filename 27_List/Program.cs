// File list.cs
// Manipulating the list data structure

/*-----------Note--------------*/
// 1. List in C sharp is a Generic Collections that helps to store and manage a list of objects in array type
// 2. Add(): Add element to list
// 3. Count: Count element list
// 4. Insert(): Insert element at position
// 5. Contains(): Check element contains certain element result boolean

using System;
using System.Collections.Generic;
namespace ListExample {
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList =new List<int>();
            List<int> MyList2 =new List<int>(5);

            List<int> MyList3 =new List<int>(MyList2);

            List<string> MyList4= new List<string>();

            MyList4.Add("Lambda");
            MyList4.Add("Roots");
            Console.WriteLine("Count element of list {0}",MyList4.Count);
            foreach (string item in MyList4)
            {
                Console.Write(" "+item);
            }


            MyList4.Insert(0,"Lambda");

            bool isexit=MyList4.Contains("amam");
            Console.WriteLine(isexit);

            
        }
    }
}