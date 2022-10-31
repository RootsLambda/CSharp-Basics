// File learnfor.cs
// Structure Loop goto and for

/*-----------Syntax--------------*/
// 1. goto Label;
//    Label:
//      <statement>;

// 2. for(start_variable_loop,end_variable_loop,step)
//   {
//    <statement>;
//   }

using System;
namespace Learnfor
{
    class Program
    {
        static void Main(string[] arg)
        {
            
            goto Label;
                Console.WriteLine("Roots");
            Label:
                Console.WriteLine("Lambda");

            int sum =0;
            for (int k=1; k<10;k++)
                sum =sum + k;
            Console.WriteLine(sum);
        }
    }
}
