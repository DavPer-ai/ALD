using SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL_TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> test = new SinglyLinkedList<int>();

            test.Add(15);
            test.Add(2);
            test.Add(3);
            test.Add(5);

            //Console.WriteLine($"{test.}")

            var exist = test.Contains(3);

            var a= test.Remove(3);

            var exist2 = test.Contains(3);

        }
    }

    internal class Helikopter
    {
        int _id;

        public Helikopter(int id)
        {
            this._id = id;
        }

        public override bool Equals(object obj)
        {
            var heli = obj as Helikopter;
            if (heli == null) return false;

            return heli._id == _id;
        }
    }
}
