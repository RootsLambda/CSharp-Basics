using System;
namespace Learnfunc
{
    class Program
    {
        static int value =5;
        static void Main(string[] args)
        {
            Demo();
            // [Tu khoa 1][Tu khoa 2]<kieu tra ve> <Ten ham> (Parameter[])
            // Tu khoa 1, tu khoa 2: public, static, read only, private
            // Kieu tra ve: int, long, voild, Sinhvien
            // Ten ham: ten goi
            // parameter:  tham so truyen vao su dung noi bo ham
            Console.WriteLine(sumtwonumber(3,4));

        }
        static void Demo()
        {
            
            Console.WriteLine("HowKteam");
        }
        static int Anumber()
        {
            return 5;
        }
        static int sumtwonumber(int firstnumber, int secondnumber)
        {
            return firstnumber + secondnumber;
        }
    }
}
