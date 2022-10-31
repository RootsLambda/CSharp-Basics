// File learnarray.cs
// Concept array C

/*-----------Syntax--------------*/
// <type_array>[length] <name_array> = new <type_array>[length] {element 1, element 2, ...};

// /*-------------Note------------*/
// 1.The new keyword helps to allocate memory may or may not
// 2.Character arrays are views as character strings
// 3.The ends element of the array must be null '\0'
//

using System;
namespace Leararray
{
  class Program
  {
    static void Main(string[] args)
    {
        // Array 1 demension
        string[] arrayA =new string[10];
        string[] arrayB = new string[]{"Roots","Lambda"};
        int[] arrayC={3,9,10};

        for (int i=0; i<arrayB.Length;i++)
        {
            Console.WriteLine(arrayB[i]);
        }

        for (int i=0; i<arrayC.Length;i++)
        {
            Console.WriteLine(arrayC[i]);
        }

        // Array 2 dimension
        string[,] arrayD = new string[2,3];

        int[,] arrayE = new int[,]
                           {
                            {1, 2},
                            {3, 4},
                            {5, 6}
                            };
        for (int i=0; i<arrayE.GetLength(0);i++)
        {
            for (int j=0; j<arrayE.GetLength(1);j++)
            {
                 Console.WriteLine(arrayE[i,j]);
            }
        }               
      
    }
  }
}
