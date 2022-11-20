using System;
using System.Collections;
// delegate bien thay the cho ham
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

            Console.WriteLine("Gia tri da convert"+valueConverted);
        }
        static int CovertStringToInt(string stringValue)
        {
            int valueInt=0;
            Int32.TryParse(stringValue, out valueInt);
            Console.WriteLine("Da ep kieu du lieu");
            return valueInt;
        }
    }
}