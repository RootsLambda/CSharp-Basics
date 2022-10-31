// File operator.cs
// Introduction to common operators in C sharp

/*-------------Note------------*/
// 1. Variables need to be declared first
// 2. Format number we use the character {}, + 
// 3. Explicit, Implicit, built-in method for squeezing

using System;
namespace Operator
{
   class Program
   {
    static void Main(string[] args)

    {   
        // 1.Arithmetic expression
        int a=4, b=5;
        Console.WriteLine("Add: {0}",a+b);
        Console.WriteLine("Subtract: {0}",a-b);
        Console.WriteLine("Mutily: {0}",a*b);
        Console.WriteLine("Divide: "+(float)a/b);

        // 2.Comparison expression
        float c=4.5f, d=3.4f;
        Console.WriteLine("Operator '>' is greater: {0}",c>d);
        Console.WriteLine("Operator '<' is less: {0}",c<d);
        Console.WriteLine("Operator '==' is equality: {0}",c==d);
        Console.WriteLine("Operator '!=' is not equality: {0}",c!=d);

        // 3.Logical operator

        bool e =true, f= false;
        Console.WriteLine(!e);
        Console.WriteLine(e && f);
        Console.WriteLine(e||f);

        // 4. Complex expression
         int r = 3;
         double area = 3.14*r*r;
         Console.WriteLine("Area is cricle: {0}", area);

        // 5.Squeeze style
    
        int g =300;
        byte h =(byte)g;

        // Use built-in methods and classes
        
        string s="10";
        int k=int.Parse(s);
        double w=double.Parse("10.9");

        int Result;
        bool aa;
        string Data1="10";
        aa=int.TryParse(Data1,out Result);

        int val= Convert.ToInt32("9");



    }

   }

}

