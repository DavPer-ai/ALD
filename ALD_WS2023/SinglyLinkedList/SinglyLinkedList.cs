using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    internal class Node<T>
    {
        public Node(T item)
        {
            m_data = item;
        }

        public Node<T> m_next { get; set; }

        public T m_data {  get; set; }
    }
    public class SinglyLinkedList<T>
    {
        Node<T> m_head { get; set; }
        Node<T> m_last { get; set; }
        int m_cnt { get; set; }

        public void Add(T item)
        {
            m_cnt++;

            Node<T> tmp = new Node<T>(item);

            if(m_head== null)
            {
                m_head = tmp;
                m_last = tmp;
                return;
            }

            m_last.m_next = tmp;
            m_last = tmp;
        }


        public bool Contains(T item)
        {
            //Node<T> current = m_head;
            //while (current!= null) 
            //{
            //    if (current.m_data.Equals(item))
            //        return true;

            //    current = current.m_next;
            //}


            for(Node<T> i = m_head; i != null ; i = i.m_next)
            {
                if (i.m_data.Equals(item)) return true;
            }
            return false;
        }

        public bool Remove(T item)
        {
            Node<T> prev = m_head;

            if (m_head.m_data.Equals(item))
            {
                m_head = m_head.m_next;
                return true;
            }

            for (Node<T> i = m_head; i != null; i = i.m_next)
            {

                if (i.m_data.Equals(item))
                {
                    if (m_last.Equals(item)) m_last = prev;
                    prev.m_next = i.m_next;
                    m_cnt--;
                    return true;
                }
                prev = i;
            }

            return false;
        }

        public bool IsObjectAtIndex(T item, int index)
        {
            int j = 0;//Count des aktuellen Objektes

            for (Node<T> i = m_head; i != null; i = i.m_next)
            {        
                if (j== index)
                {
                    if (i.m_data.Equals(item))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                j++;
            }
            return false;
        }

        public T FindByIndex(int index)
        {
            int j = 0;//aktuelles Objekt

            for (Node<T> i = m_head; i != null; i = i.m_next)
            {
                if (j == index)
                {
                    return (i.m_data);
                }
                j++;
            }

            //return default(T);

            throw new IndexOutOfRangeException();
        }

        public int Count()
        {
            return m_cnt;
        }

        public void Clear()
        {
            m_head = null;
            m_last = null;
            m_cnt = 0;
        }
    }
}
