// File learnwhile.cs
// Introduce while loop and do while

/*-----------Syntax--------------*/
// 1. while (expression)
//  {
//   <statement>;
//  }

// 2. do
// {
//   <statement 1>    
// }
// while (expression);

using System;
namespace Learnwhile
{
    class Program
    {
        static void Main(string[] arg)
        {
            int x = 5;
            while (x<25)
            {
                x=2*x - 1;
            }   
            Console.WriteLine(x);

            int k =1,sum=0;
            do{
                sum+=k;
                k++;

            } while (k<10);

            Console.WriteLine(sum);
        }
    }
}
