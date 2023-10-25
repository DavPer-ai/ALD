using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    //Resize Copy Methoden
    internal class ArrayList<T>
    {
        public ArrayList(T[] initArray) 
        {
            Count = initArray.Length;
            Array = initArray;
        }

        public static int Count { get; set; }

        public T[] Array;

        public void Add(T item)
        {
            Count++;

            if (Count  > Array.Length)
            {
                System.Array.Resize<T>(ref Array, Array.Length * 2);
            }

            Array[Count] = item;
        }


    }
}
