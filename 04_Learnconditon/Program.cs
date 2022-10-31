// File Learncondition
// Conditional branch statement and trinitarian operator

/*-----------Syntax--------------*/
// 1. if <condition>
//    {block statement}

// 2. if <condition>  
//    {block statement 1}
//   else {block statement 2}

// 3. if <condition 1>
//    {block statement 1}
//   else if <condition 2>
//    {block statement 2}
//   ...
//   else {block statement n}

// 4. Conditon ? Value 1: Value 2 ;
// If true, return value 1
// If false, return value 2 

using System;
namespace Learnconditon
{

    class Program
    {

        static void Main(string[] arg)
        {
            // Condition if
            string a,b;
            int max;
            a=Console.ReadLine();
            b=Console.ReadLine();

            int c = int.Parse(a);
            int d =int.Parse(b);

            max =c;
            if (c<d){
                max=d;
            }
            Console.WriteLine("Max a and b: {0}",max);

            // Condition if-else
            if(c>d)
            {
                max =c;
            }
            else{
                max =d;
            }

            // Conditon if-else if-else
            int k =-1;
            if (k==6){
                Console.WriteLine("{0} is a number equal to 6",k);
            }
            else if (k>6){
                Console.WriteLine("{0} is a number greater than 6",k);
            }
            else if (0<k  && k<6 ){
                Console.WriteLine("{0} is a number less than 6",k);
            }
            else
                Console.WriteLine("{0} is a number nagetive",k);
            
            // Trinitarian operator
            string root="Lambda";
            bool s=root=="Lambda"?true:false;
            
        }
    }
}

