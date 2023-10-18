using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    internal class Node<T>
    {
        public Node<T> m_next { get; set; }

        T m_data {  get; set; }
    }
    public class SinglyLinkedList<T>
    {
        Node<T> m_head { get; set; }
        Node<T> m_last { get; set; }
        int m_cnt { get; set; }

        void Add(T item)
        {
            m_cnt++;

            Node<T> tmp = new Node<T>();
            if(m_head== null)
            {
                m_head = tmp;
                m_last = tmp;
                return;
            }

            m_last.m_next = tmp;
            m_last = tmp;
        }

    }
}
