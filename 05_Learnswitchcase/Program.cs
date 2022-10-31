// File Learnswitchcase.cs
// No Conditional branch statement

/*-----------Syntax--------------*/
// switch (<expression>){
// case value 1: block 1; break;
// case value 2: block 2; break;
// ....
// default:
//     block 0;
//     break;
// }

using System;
namespace Learnswitchcase{

    class Program
    {
        static void Main(string[] arg)
        {       
            int n = 40;
            switch (n)
                    {
                    case 0: 
                            Console.WriteLine("Hello");
                            break;
                    case 20: 
                            Console.WriteLine("World");
                            break;
                    case 40: 
                            Console.WriteLine("Lambda");
                            break;
                    default:
                            Console.WriteLine("Roots");
                            break;
                    }

        }
    }
}

