using System;
using System.Collections; // thu vien
namespace ArrayListExample {
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList MyArray= new ArrayList();

            ArrayList MyArray2=new ArrayList(5);

            ArrayList MyArray3=new ArrayList(MyArray2); // Tao clone giong
            
            ArrayList arrpersons= new ArrayList();

            arrpersons.Add(new Person("Lambda",17));
            arrpersons.Add(new Person("Roots",45));
            arrpersons.Add(new Person("Gana",35));

            Console.WriteLine("Danh sach ban dau:");
            foreach(Person item in arrpersons) {
                Console.WriteLine(item.ToString());
            }

            arrpersons.Sort(new SortPersons());
           Console.WriteLine("Dan sach da sap xep theo tuoi:");
            foreach(Person item in arrpersons) {
                Console.WriteLine(item.ToString());
            }


        }
    }
    public class SortPersons:IComparer
    {
        public int Compare(object x, object y) {
            Person p1=x as Person;
            Person p2=y as Person;

            if (p1==null||p2==null)
            {
                throw new InvalidOperationException();
            }
            else{
                if (p1.Age<p2.Age) 
                {
                    return 1;
                }
                else if (p1.Age==p2.Age) {
                    return 0;
                }
                else 
                {
                    return -1;
                }
            }
        }

    }
}

