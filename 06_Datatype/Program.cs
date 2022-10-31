// File datatype.cs
// Data types in c sharp

/*-----------Note--------------*/
// 1. Constants are variables that do not change throughout the program'
// 2. Convert value data type to reference data type is boxing
// 3. convert reference data type to value data type is unboxing
// 4. Var is a keyword not a data type
// 5. Using dynamic makes type values undefined when it comes to execution

using System;
namespace Datatype
{

    class Program
    {

        static void Main(string[] arg)
        {
            // constant
            const int x =10;

            // object
            object obj="Lambda";

            // boxing
            int value =109;
            object objectValue =value;

            // unboxing
            int newValue=(int)objectValue;

            // var
            var message="Roots";
            Console.WriteLine(message);

            // dynamic
            dynamic sequence ="Lambda";
            sequence++;

        }
    }
}
