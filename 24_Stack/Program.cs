// File stack.cs
// Manipulating stack data structures

/*-----------Note--------------*/
// 1. Stack is a data structure that works on the principle of last in first out
// 2. Push(): Push the component onto the stack
// 3. Count: Count the number of elements of the stack
// 4. Peek(): Look at the first element of the stack
// 5. Pop(): Get the last element off the stack

using System;
using System.Collections;

namespace StackExample {
    class Program {
        static void Main(string[] args) {
            Stack MyStack =new Stack();

            Stack MyStack2 =new Stack(5);
            
            ArrayList MyArray=new ArrayList();

            MyArray.Add(5);
            MyArray.Add(4);

            Stack MyStack3=new Stack(MyArray);

            Stack MyStack4=new Stack();
            
            MyStack4.Push("Lambda");
            MyStack4.Push("Roots");
            MyStack4.Push("How");

            Console.WriteLine("Count element of stack: {0}",MyStack4.Count);

            Console.WriteLine("First element of stack: {0} ",MyStack4.Peek());

            int Length=MyStack4.Count;

            for(int i=0 ; i<Length;i++) {
                Console.WriteLine("Pop:"+MyStack4.Pop());

            }
        }
    }
}
