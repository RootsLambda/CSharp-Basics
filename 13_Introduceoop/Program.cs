// File introduceoop.cs
// Introduction to object-oriented programming in c sharp

/*-------------Note------------*/
// 1. Public scope allows us to access class properties
// 2. The new keyword allows us to allocate memory for the class object


using System;
namespace Introduceoop{
    class Student
    {
        public String name;
        public int age;
        public void Info()
        {
            Console.WriteLine("Name "+name);
            Console.WriteLine("Age: "+age);
        }
    }


    // class Cat
    // {
    //     public double Weight;
    //     public double Height;
    //     // Contructor không có tham số
    //     public Cat(){
    //         Weight =800;
    //         Height=10;
    //     }

    //     // Contructor có tham số
    //     public Cat(int w, int h) {
    //         Weight=w;
    //         Height=h;
    //     }
    //     ~Cat() {
    //         Console.WriteLine("Destructor");
    //     }
    //     public void Info(){
    //         Console.WriteLine("Height: "+Height+" Weight: "+Weight);
    //     }
    // }
    class Program{
        static void Main(string[] args) {
            Student st =new Student();
            st.name="Lambda";
            st.age=21;

            st.Info();

            // // Animal Cat=new Animal();
            // // Cat.Weight=1;
            // // Cat.Height=30;

            // // Dog.Info();
            // // Cat.Info();

            // Cat BlackCat=new Cat();

            // BlackCat.Info();

            // Cat WhiteCat=new Cat(1200,30);

            // WhiteCat.Info();

        }
    }
}

