using SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL_TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestSinglyLinkedList();

            TestSinglyLinkedListWithDictionary();
        }

        private static void TestSinglyLinkedList()
        {
            SinglyLinkedList<string> test = new SinglyLinkedList<string>();

            test.Add("a");
            test.Add("b");
            test.Add("c");
            test.Add("d");

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

        private static void TestSinglyLinkedListWithDictionary()
        {
            SinglyLinkedList<string> wordList = DicReader.ReadDictionary();

            Console.WriteLine("Geben Sie bitte eine Text ein:");

            string textToTest = Console.ReadLine();

            string[] wordsToTest = textToTest.Split(' ');

            foreach (string word in wordsToTest)
            {
                if (wordList.Contains(word))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(word);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(word, ConsoleColor.White);
                }

                Console.Write(' ');
            }

            Console.ReadLine();
        }
    }
}
