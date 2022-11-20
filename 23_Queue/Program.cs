using System;
using System.Collections;

namespace QueueExmaple {
    class Program {
        static void Main(string[] args) {
            Queue myque= new Queue();
            Queue myque2 =new Queue(2);

            Queue myque4= new Queue();

            myque4.Enqueue("Roots");
            myque4.Enqueue("Lambda");
            myque4.Enqueue("agna");

            Console.WriteLine("So phan tu cua queue: {0}", myque4.Count);

            Console.WriteLine("Phan tu dau cua queue :{0}",myque4.Peek());

            int Length= myque4.Count;
            for (int i=0; i<Length;i++) {
                Console.WriteLine("Xoa phan tu: {0}",myque4.Dequeue());
            }
        } 
    }
}