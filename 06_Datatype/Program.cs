using System;
namespace Datatype
{

    class Program
    {

        static void Main(string[] arg)
        {
            // Hang la bien khong thay doi trong suot chuong trinh
            //
            const int x =10;
            object obj="HowKteam.com";
            // boxing: chuyen kieu du lieu gia tri sang kieu du lieu tham chieu
            int value =109;
            object objectValue =value;
            // unboxing: chuyen kieu du lieu tham chieu sang kieu du lieu gia tri
            int newValue=(int)objectValue;
            // Khai bao bien bang tu khoa var
            // var la tu khoa khong phai kieu du lieu
            var varBool=true;
            var content="HowKteam";
            Console.WriteLine(content);

            dynamic StringValue ="HowKteam";
            // Cac gia tri kieu chua xac dinh khi den thuc thi
            StringValue++;



        }
    }
}
