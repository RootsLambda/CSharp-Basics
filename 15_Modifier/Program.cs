// File modifier.cs
// Access scopes of classes, methods, attribute;

/*------------Note-----------*/
// 1. Default class attribute are private
// 2. Default method class are public
// 3. To access the private property, you must go through the method
// 4. get: Query on attribute
// 5. set: update on attribute

using System;
namespace Modifier {
    class Customer{
        
        private int Id;
        private string Name;
        private double Cost_Item;

        public double cost_item
        { 
            get 
            { 
                return Cost_Item; 
            }

            set 
            {
                Cost_Item=value;
            }
        }
     
        public int getId() 
        {
            return Id;
        }

    }
    class Program {
       static void Main(string[] args) 
       {
        Customer c=new Customer();
        c.cost_item=222;

        Console.WriteLine("Price of items currently: "+c.cost_item);

       } 
    }
}

