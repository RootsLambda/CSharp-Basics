// File constructor_and_destructor.cs
// How to create Object constructors and destructors

/*-------------Note------------*/
// 1. Constructor with default parameters
// 2. Constructor takes a parameter
// 3. Destructor destroy objects of classes.

/*-------------Syntax------------*/
// 1. Constructor
//    nameclass(datatype parameter 1, datatype parameter 2, ...) 
//    {
//    
//    }

// 2. Destructor 
// ~nameclass()
// {
//    
// }

using System;
namespace Introduceoop{
    class Student
    {
        public String name;
        public int age;

        public Student() 
        {
            name="Roots";
            age=21;
        }

        public void Info()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
        }
    }
    class Cat 
    {
        public String name;
        public int age;
        public Cat(String n, int a) 
        {
            name=n;
            age=a;
        }

        public void Info()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
        }

    } 
    class Dog
    {
        public Dog()
        {
            Console.WriteLine("Call Constructor");
        }
        ~Dog()
        {
            Console.WriteLine("Call Destructor");
        }
    }
       
    class Program{
        static void Main(string[] args) {
            Student st =new Student();
            st.Info();

            Cat c= new Cat("Meko",2);
            c.Info();
            
            Dog d = new Dog();

        }
    }
}


