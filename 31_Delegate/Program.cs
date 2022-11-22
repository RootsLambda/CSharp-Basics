// File delegate.cs
// Introduction to delegates in c sharp

/*-------------Note------------*/
// 1. Delegate is a reference type variable that holds a reference to a method.
// 2. Declaring Delegate will be similar to declaring a variable

using System;
using System.Collections;

namespace Delegate
{
    class Program
    {
        delegate int MyDelegate(string s);

        static void Main(string[] args)
        {
            
            MyDelegate convertToInt= new MyDelegate(CovertStringToInt);
            string numberSTR="35";

            int valueConverted =convertToInt(numberSTR);

            Console.WriteLine("Value convert"+valueConverted);
        }
        static int CovertStringToInt(string stringValue)
        {
            int valueInt=0;
            Int32.TryParse(stringValue, out valueInt);
            Console.WriteLine("Data type casting successful");
            return valueInt;
        }
    }
}