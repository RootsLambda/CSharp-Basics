// File interface.cs
// How to use interface in c sharp

/*-----------Note--------------*/
// 1. Interface is a set of components with only declarations without a definition
// 2. Component: method, property, event, ...
// 3. Interface has neither constructor nor destructor.
// 4. It is not possible to declare access scope for elements inside the interface. 
// 5. These components will default to public.
// 6. C sharp does not support multiple inheritance, so interface was solution for this multiple inheritance.

using System;
namespace Interface {
    interface ISpeak 
    {
        void Speak();
    }
    
    class Animal:ISpeak {
        public void Speak() {
            Console.WriteLine("Animal is speaking...");
        }
    }
    class Program {
        static void Main(string[] args) {
            Animal animal =new Animal();
            animal.Speak();
        }
    }
}
