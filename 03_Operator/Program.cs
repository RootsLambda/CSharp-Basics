// File operator.cs
// Introduction to common operators in C sharp

/*-------------Note------------*/
// 1. Variables need to be declared first
// 2. Format number we use the character {}, + 


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
        Console.WriteLine("Divide: "+a/b);

        // 2.Comparison expression
        float c=4.5f, d=3.4f;
        Console.WriteLine("Operator '>' is greater: %d\n",c>d);
        Console.WriteLine("Operator '<' is less: %d\n",c<d);
        Console.WriteLine("Operator '==' is equality: %d\n",c==d);
        Console.WriteLine("Operator '!=' is not equality: %d\n",c!=d);

        // 3.Logical operator

        bool e =true, f= false;
        Console.WriteLine(!e);
        Console.WriteLine(e && f);
        Console.WriteLine(e||f);

        // 4. Complex expression
         int r = 3;
         double area = 3.14*r*r;
         Console.WriteLine("Area is cricle: %f", area);

        // Ep kieu
        // Chuyen doi ngam dinh 
        // Chuyen doi tuong minh
        int g =300;
        byte h =(byte)g;

        Console.WriteLine(e);
        Console.WriteLine(r);
        int m=5;
        int n=2;
        float tt;
        tt=(float)m/n;


        // Su dung phuong thuc, lop ho tro sẵn'
        string s="10";
        int k=int.Parse(s);
        double w=double.Parse("10.9");

        int Result;
        bool aa;
        string Data1="10";
        aa=int.TryParse(Data1,out Result);

        int val= Convert.ToInt32("9");

        // Người dùng tự định nghĩa chuyển đổi



    }

   }

}

