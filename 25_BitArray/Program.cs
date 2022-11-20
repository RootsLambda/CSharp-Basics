using System;
using System.Collections;

namespace BitArrayExample {
    class Program {
        static void Main(string[] args) {
            BitArray MyBA=new BitArray(10);  // luu tru moi phan tu 1 bit
            BitArray MyBA2=new BitArray(10,true);

            byte[] MyBytes=new byte[5] {1,2,3,4,5};
            BitArray MyBA4= new BitArray(MyBytes);

            Console.WriteLine("Do dai cua bit array: {0}",MyBA4.Length);

        }
    }
}

