// File learnfunc.cs
// Show us function basics

/*-----------Syntax--------------*/
// <Keyword> <Return_type> <name funcion>(type variable1, type variable2, .....)
// {
//          <Statement>;
// return value 
// }

/*-----------Note--------------*/
// 1. If return type 'void' will no return value
// 2. Keyword can public, static, read only, private
// 3. Return Type: int, long, double, void
// 4. Parameters inside the function

using System;
namespace Learnfunc
{
    class Program
    {
        static int value =5;

        static int add(int x, int y)
        {
            return x+y;
        }
        
        static void printA()
        {
            Console.WriteLine("Lambda");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(value);
            Console.WriteLine("Result add: {0}", add(3,4));
            printA();
            

        }   
    }
}
