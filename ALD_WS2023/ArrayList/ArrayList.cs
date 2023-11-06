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
            _Array= new Node<T>[initArray.Length];
            
            for (int i = 0; i < initArray.Length; i++)
            {
                _Array[i] = new Node<T>(initArray[i]);
            }

            _Count = initArray.Length;
            //Array = initArray;
        }

        public static int _Count { get; set; }

        public Node<T>[] _Array;

        public void Add(T item)
        {
            _Count++;

            if (_Count  > _Array.Length)
            {
                System.Array.Resize<Node<T>>(ref _Array, _Array.Length * 2 + 1);
            }

            _Array[_Count-1] = new Node<T>(item);
        }

        public void InsertAt(int index, T item)
        {
            _Count++;

            if (_Count > _Array.Length)
            {
                System.Array.Resize<Node<T>>(ref _Array, _Array.Length * 2);
            }

            System.Array.Copy(_Array, index, _Array, index + 1, _Array.Length - (index + 1));

            _Array[index] = new Node<T>(item);
        }

        public void RemoveAt(int index)
        {
            _Count--;

            System.Array.Copy(_Array, index + 1, _Array, index, _Array.Length - (index + 1));

            _Array[_Count] = null;

            if (_Count <= _Array.Length/2)
            {
                System.Array.Resize<Node<T>>(ref _Array, _Array.Length / 2);
            }
        }

        public void Remove(T item)
        {
            for (int i = 0; i < _Array.Length; i++)
            {
                if (_Array[i] != null)
                {
                    if (_Array[i].Value.Equals(item))
                    {
                        RemoveAt(i);
                    }
                }
            }
        }

        public void Clear()
        {
            _Count = 0;
            _Array = new Node<T>[0];
        }

        public int Count()
        {
            return _Count;
        }

        public T this[int index]
        {
            get
            {
                if(0 < index && index < _Count)
                {
                    return _Array[index].Value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }

            }
            set
            {
                if(0 < index && index < _Count)
                {
                    _Array[index].Value = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
