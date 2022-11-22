// File generic.cs
// Help us understand generics in c sharp

/*-----------Note--------------*/
// 1. Generic help define a function, a class without specifying the data type argument 
// 2. You just need to put a certain letter in place of the data type
// 3. When calling the function you indicate what data type you are manipulating

using System;
using System.Collections;

namespace Generic {
    class Program 
    {
        public static void Swap<Lambda>(ref Lambda a, ref Lambda b) 
        {
            Lambda temp=a;
            a=b;
            b=temp;

            Console.WriteLine(a+" and "+b);
        }
        static void Main(string[] args) {
            int a=5,b=7;
            double c=1.3, d=4.5;

            Swap<int>(ref a, ref b);
            Swap<double>(ref c, ref d);

            MyGeneric<int> MyG= new MyGeneric<int>(5);

            MyG.SetItemValue(0,10);


        }
    }
}
