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
            test.Add(15);
            test.Add(15);
            test.Add(15);

            //Console.WriteLine($"{test.}")

            var exist = test.Contains(15);


            Helikopter A = new Helikopter(1);
            Helikopter B = new Helikopter(2);

            SinglyLinkedList<Helikopter> helis = new SinglyLinkedList<Helikopter>();

            //helis.Add(A);
            helis.Add(B);

            var b= helis.Contains(A);
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
