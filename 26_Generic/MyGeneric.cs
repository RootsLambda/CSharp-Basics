
using System;

namespace Generic{
    public class MyGeneric<T> 
    {
        private T[] items;
        public T[] Items
        {
            get {return items; }
        }
        
        public MyGeneric(int Size)
        {
            items=new T[Size];
        }

        public T GetByIndex(int Index)
        {
            if (Index<0||Index>=items.Length) 
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return items[Index];
            }
        }
        
        public void SetItemValue(int Index, T Value) {
            if (Index<0 || Index >=items.Length) 
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                items[Index] =Value;
            }


        }
    }
}