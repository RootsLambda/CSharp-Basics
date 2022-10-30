// File iosimple.cs
// Introduction to simple input, annotation commands

/*-------------Note------------*/
// 1. Declare using to use the library System
// 2. Need to declare namespace and class for the program
// 3. Static is a keyword and void returns no value
// 5. Entry point of the program starts function Main(string[] args)
// 6. Output using the function Console.Write()
// 7. Output and next new line using the function Console.WriteLine()
// 8. Input using the function Console.Read()
// 9. Input and next new line using the function Console.ReadLine()
// 10. Stop the screen to see the result using the command Console.ReadKey() default False
// 11. Annotating on a line we use the // operator and mutiply use /*<text>*/

using System;

namespace iosimple
{
    class Program
    {
        static void Main(string[] args)
        {  
           
            Console.Write("Lambda");
            Console.Write(10);
            Console.Write(true);

            Console.WriteLine("Hello world!"); 
            Console.Write("Hello world!\n");


            int a=5;
            Console.Write("a = {0}",a);
            Console.Write("a = "+a);

            Console.Write(Console.Read()); 
            Console.Write(Console.ReadLine()); 
            Console.ReadKey(); 
        
        }
    }
}