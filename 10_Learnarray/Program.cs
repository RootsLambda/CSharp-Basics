using System;
namespace Leararray
{
  class Program
  {
    static void Main(string[] args)
    {
        // new giup cap phat vung nho 
        string[] arrayA =new string[10];
        string[] Kteam = new string[]{"HowKteam","Free Education"};
        int[] IntArray={3,9,10};
        for (int i=0; i<3;i++)
        {
            Console.WriteLine(arrayA[i]);
        }

        Console.WriteLine(Kteam[0]);
        string[] HotenSinhVien = new string[5];
        for(int i=0; i< HotenSinhVien.Length;i++)
        {
            HotenSinhVien[i]=Console.ReadLine();
        }

        string[,] Array;
        string[,]  A=new string[2,3];

        string[,] K8= new string[,]
                        {
                            {"1","2"},
                            {"2","3"},
                            {"3","4"}

                        };
        Console.WriteLine(K8[2,1]);

      K8.GetLength(0);
      K8.GetLength(1);
      K8.Rank;
    }
  }
}
