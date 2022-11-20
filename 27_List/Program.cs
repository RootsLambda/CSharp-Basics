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
            MyList4.Add("Free");
            MyList4.Add("Edu");
            Console.WriteLine("So phan tu trong list {0}",MyList4.Count);
            foreach (string item in MyList4)
            {
                Console.Write(" "+item);
            }

            Console.WriteLine();

            MyList4.Insert(0,"Lambda");

            bool isexit=MyList4.Contains("amam");

            
        }
    }
}