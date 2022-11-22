// File dictionary.cs
// Manipulating dictionary data structures

/*-----------Note--------------*/
// 1. Add(): add key-value pair

using System;
using System.Collections.Generic;
namespace Dictionary{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> MyDic=new Dictionary<string, string>();

            Dictionary<string,string> MyDic2= new Dictionary<string, string>(5);

            Dictionary<string,string> MyDic3=new Dictionary<string, string>(MyDic2);

            Dictionary<string,string> MyDic4=new Dictionary<string, string>();

            MyDic4.Add("aa","Lamda");
            MyDic4.Add("ssd","As");

            foreach(KeyValuePair<string, string> item in MyDic4)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
        }
    }
}