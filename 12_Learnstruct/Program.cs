using System;
namespace Learnstruct
{
    class Program
    {
        struct SinhVien
                {
                    public int Maso;
                    public string Hoten;

                
                }
        static void NhapThongtinsinhvien(SinhVien SV)
        {
             Console.Write("Ma so");
             SV.Maso=int.Parse(Console.ReadLine());


        }
        static void Main(string[] args)
        {
              SinhVien SV1 =new SinhVien();
              NhapThongtinsinhvien(SV1);  

        }
    }
}
