// File keywordstatic.cs
// Help us understand the static keyword in c sharp

/*-----------Note--------------*/
// 1. Static declaration allows us to understand that only one memory area is allocated
// 2. Variable static
// 3. Method static
// 4. Class Static

using System;
namespace Keyworkstatic {
    class Cat {
        private double weight;
        private double height;

    public double Weight {
        get {return weight;}
        set {weight =value;}
    }

    public double Height {
        get { return Height;}
        set {Height =value;}
    }

    public static int Count=0;

    public Cat() 
    {
        weight=20;
        height=500;
        Count++;
    }

    }

    static class Caculate {
        public static long pow(int number, int hat) {
            long result=1;
            for (int i=0; i<hat;i++) {
                result=result*number;
            }
            return result;
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Initial number of cats: "+Cat.Count);

            Cat BlackCat=new Cat();
            Console.WriteLine("Current number of cats: " +Cat.Count);

            Cat WhiteCat=new Cat();
            Console.WriteLine("Current number of cats: " +Cat.Count);

            Console.WriteLine("Value of caculation: "+ Caculate.pow(2,3));
        }
    }
}
