// File inheritance.cs
// Introduction to inheritance in c sharp

/*-----------Note--------------*/
// 1. C sharp does not support multiple inheritance
// 2. Private scopes are not inherited
// 3. If the parent class has a constructor, 
// 4. the child class must have the base keyword to inherit that constructor

using System;
namespace Inheritance {

    class Animal {
        protected double Weight;
        protected double Height;
        protected static int Legs;

        public void Info() {
            Console.WriteLine("Weight: "+Weight +"Height: "+Height+"Legs: "+Legs);
        }
        public Animal() 
        {

        }
        public Animal(double w, double h, int l) 
        {
            Weight=w;
            Height=h;
            Legs=l;
        }
    }

    class Cat : Animal {
        public Cat() {
            Weight=500;
            Height=20;
            Legs=2;
        }

        public Cat(double w, double h, int l):base(w,h,l)
       {

       }
    
    }   

 class Program {
        static void Main(string[] args) 
        {
            Cat BlackCat =new Cat();
            BlackCat.Info();

        }
    }
}

