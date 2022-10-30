using System;
namespace Learnforeach
{
    class Program
    {
        static void Main(string[] args)
        {    
            int[] intArray={1,4,5,5,6,2};
            int Sum=0; 
            foreach(int item in intArray)
            {
                Console.WriteLine("\t"+item);
                Sum+=item;
            }
            Console.WriteLine("\n Sum ="+Sum);
        }
    }
}

