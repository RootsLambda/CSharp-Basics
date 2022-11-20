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

            Stack MyStack4=new Stack();
            
            MyStack4.Push("Lambda");
            MyStack4.Push("Roots");
            MyStack4.Push("How");

            Console.WriteLine("So phan tu trong stack: {0}",MyStack4.Count);

            Console.WriteLine("Phan tu dau tien la: {0} ",MyStack4.Peek());

            int Length=MyStack4.Count;

            for(int i=0 ; i<Length;i++) {
                Console.WriteLine("Pop:"+MyStack4.Pop());

            }
        }
    }
}
