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
            SinglyLinkedList<string> test = new SinglyLinkedList<string>();

            test.Add("a");
            test.Add("b");
            test.Add("c");
            test.Add("d");

            //Console.WriteLine($"{test.}")

            var a1 = test.IsObjectAtIndex("a", 0);

            var a2 = test.IsObjectAtIndex("a", 1);

            var b1 = test.FindByIndex(2);

            var b2 = test.FindByIndex(3);

            var b3 = test.FindByIndex(2);

            var count = test.Count();

            var c1 = test.FindByIndex(1);

            test.Remove("b");

            var c2 = test.FindByIndex(1);

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
