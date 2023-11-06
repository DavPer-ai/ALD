using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinglyLinkedList;

namespace SLL_TestApp
{
    internal static class SinglyLinkedListTestClass
    {
        private static void TestSinglyLinkedList()
        {
            SinglyLinkedList<string> test = new SinglyLinkedList<string>();

            test.Add("a");
            test.Add("b");
            test.Add("c");
            test.Add("d");

            //var a1 = test.IsObjectAtIndex("a", 0);

            //var a2 = test.IsObjectAtIndex("a", 1);

            //try
            //{
            //    var b1 = test.FindByIndex(1);

            //    var b2 = test.FindByIndex(2);

            //    var b3 = test.FindByIndex(3);

            //    var count = test.Count();

            //    var c1 = test.FindByIndex(1);

            //    test.Remove("b");

            //    var c2 = test.FindByIndex(1);

            //    var c3 = test.Count();

            //    test.Clear();

            //    var d1 = test.Count();

            //    var d2 = test.FindByIndex(0);
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            foreach (var i in test)
            {
                Console.WriteLine(i);
            }
        }

        private static void TestSinglyLinkedListWithDictionary()
        {
            SinglyLinkedList<string> wordList = DicReader.ReadDictionaryToSinglyLinkedList();

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
