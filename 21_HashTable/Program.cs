// File hashtable.cs
// Manipulating hashtable data structures

/*-----------Note--------------*/
// 1. Add(): Add key and value pair to Hashtable.
// 2. Count: Count the number of elements of the key value pair

using System;
using System.Collections;
namespace HashTableExample{
    class Program{
        static void Main(string[] args) {
            Hashtable MyHash= new Hashtable();

            Hashtable MyHash2= new Hashtable(5); 
            
            Hashtable MyHash3=new Hashtable(MyHash2);

            Hashtable hash=new Hashtable();

            hash.Add("L","am");
            hash.Add("K","da");
            hash.Add("Fad","id");

            Console.WriteLine(hash["K"]);

            hash["Kt"]="add";
            
            foreach (DictionaryEntry item in hash) {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }

            Console.WriteLine("Count: "+hash.Count);


        }
    }
}


