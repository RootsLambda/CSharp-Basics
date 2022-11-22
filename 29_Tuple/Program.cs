// File tuple.cs
// Manipulating tuple data structures

/*-------------Note------------*/
// 1. Initialize tuple through Create method
// 2. Initialize tuple through constructor of generic classes

using System;
using System.Collections.Generic;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyTuple = Tuple.Create<int,string>(1,"Lambda");
            var MyTuple2 =new Tuple<int,string,bool>(1,"ama",true);

            Console.WriteLine("Id: {0}, Name: {1}", MyTuple.Item1,MyTuple.Item2);

            
        

        }
    }
}