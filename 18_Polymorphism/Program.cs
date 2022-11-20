// File polypolymorphism.cs
// Introduction to object polymorphism in c sharp

/*-----------Note--------------*/
// 1. Virtual is a keyword used to declare a virtual method
// 2. Override is the keyword to mark the method to override the parent class method
// 3. We need to override the speak method of the parent class so the method of the superclass is virtual
// 4. abstract is the keyword to declare abstract and pure virtual classes

using System;
namespace Polymorphism {
    abstract class Animal {
        public virtual void Speak() {
            Console.WriteLine("Animal is speaking...");
        }
    }

    class Cat:Animal 
    {
        public override void Speak()
        {
            Console.WriteLine("Cat is speaking...");
        }
    }
    
    class Dog: Animal {
        public override void Speak()
        {
            Console.WriteLine("Dog is speaking...");
        }
    }
    class Program {
        static void Main(string[] args) {
            Animal cat=new Cat();
            Animal dog= new Dog();

            cat.Speak();
            dog.Speak();
        }
    }
}
