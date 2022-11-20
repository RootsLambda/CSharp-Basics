using System;
using System.Collections;
namespace HashTableExample{
    class Program{
        static void Main(string[] args) {
            Hashtable MyHash= new Hashtable();
            Hashtable MyHash2= new Hashtable(5); // capacity la5 
            
            MyHash2.Add("K","Tem");

            MyHash.Add("aa","aaaa");

            Hashtable MyHash3=new Hashtable(MyHash2);

            Hashtable hash=new Hashtable();
            hash.Add("k","Tem");
            hash.Add("H","HowKtema");
            hash.Add("Fad","Adsd");

            Console.WriteLine(hash["K"]);

            hash["Kt"]="add";
            
            foreach (DictionaryEntry item in hash) {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }

            Console.WriteLine("Count"+hash.Count);


        }
    }
}


