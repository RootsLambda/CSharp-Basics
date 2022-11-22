// File queue.cs
// Manipulating queue data structures

/*-----------Syntax--------------*/
// 1. Queues operate on the principle of First In First Out
// 2. Enqueue(): Add element to queue
// 3. Count: Count the number of elements of the queue
// 4. Peek(): View the first element of the queue
// 5. Dequeue(): Delete element of queue
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

            Console.WriteLine("Count of queue: {0}", myque4.Count);

            Console.WriteLine("First element of queue :{0}",myque4.Peek());

            int Length= myque4.Count;
            
            for (int i=0; i<Length;i++) {
                Console.WriteLine("Delete of queue: {0}",myque4.Dequeue());
            }
        } 
    }
}