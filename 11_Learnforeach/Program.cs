// File learnforeach.cs
// Introduce loop for each

/*-----------Syntax--------------*/
// foreach(datetype <item> in items )
// {
//   statement;
// }

using System;
namespace Learnforeach
{
    class Program
    {
        static void Main(string[] args)
        {    
            int[] arrayA={1,4,5,5,6,2};
            int Sum=0; 
            foreach(int item in arrayA)
            {
                Sum+=item;
            }
            Console.WriteLine("Sum = "+Sum);
        }
    }
}

