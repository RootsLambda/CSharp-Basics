// File learnstruct.cs
// Learn structured data

/*-----------Syntax--------------*/
// struct <name_struct> {
//        <keyword 1> <data_type> <variable 1 or array 1>;
//        <keyword 2> <data_type> <variable 2 or array 2>;
//        ......
// }

using System;
namespace Learnstruct
{
    class Program
    {
        struct Student
                {
                    public int id;
                    public string Name;
                }

        static void  Info(Student St)
        {
             Console.Write("ID: ");
             St.id=int.Parse(Console.ReadLine());
        }
        
        static void Main(string[] args)
        {
              Student St1 =new Student();
              Info(St1);  

        }
    }
}
