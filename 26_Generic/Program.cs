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
