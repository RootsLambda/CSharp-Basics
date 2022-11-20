using System;

namespace SortList {
    public class Person{
        private string name;
        private int age;

        public string Name{
            get {return name;}
            set {name=value;}

        }

        public int Age{
            get {return age;}
            set {age=value;}
        }

        public Person(string Name, int Age) 
        {
            this.Name=Name;
            this.Age=Age;
        }
        public override string ToString()
        {
            return "Name" +name+"|Age: " +age;
        }
    }
}

    