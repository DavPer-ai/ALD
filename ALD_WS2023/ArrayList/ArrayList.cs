using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class Node<T>
    {
        public Node(T value) 
        { 
            Value = value;
        }
        public T Value { get; set; }
    }
    public class ArrayList<T>
    {
        public ArrayList(T[] initArray) 
        {
            Array= new Node<T>[initArray.Length];

            for (int i = 0; i < initArray.Length; i++)
            {
                Array[i] = new Node<T>(initArray[i]);
            }

            _Count = initArray.Length;
            //Array = initArray;
        }

        public static int _Count { get; set; }

        public Node<T>[] Array;

        public void Add(T item)
        {
            _Count++;

            if (_Count  > Array.Length)
            {
                System.Array.Resize<Node<T>>(ref Array, Array.Length * 2 + 1);
            }

            Array[_Count-1] = new Node<T>(item);
        }

        public void InsertAt(int index, T item)
        {
            _Count++;

            if (_Count > Array.Length)
            {
                System.Array.Resize<Node<T>>(ref Array, Array.Length * 2);
            }

            System.Array.Copy(Array, index, Array, index + 1, Array.Length - (index + 1));

            Array[index] = new Node<T>(item);
        }

        public void RemoveAt(int index)
        {
            _Count--;

            System.Array.Copy(Array, index + 1, Array, index, Array.Length - (index + 1));

            Array[_Count] = null;

            if (_Count <= Array.Length/2)
            {
                System.Array.Resize<Node<T>>(ref Array, Array.Length / 2);
            }
        }

        public void Remove(T item)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] != null)
                {
                    if (Array[i].Value.Equals(item))
                    {
                        RemoveAt(i);
                    }
                }
            }
        }

        public void Clear()
        {
            _Count = 0;
            Array = new Node<T>[0];
        }

        public int Count()
        {
            return _Count;
        }


    }
}
