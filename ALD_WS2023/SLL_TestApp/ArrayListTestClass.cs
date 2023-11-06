using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayList;
using SinglyLinkedList;

namespace SLL_TestApp
{
    internal static class ArrayListTestClass
    {
        public static void TestPerformanceOfArrayList()
        {
            List<string> wordList = DicReader.ReadDictionaryToList();
            ArrayList<string> wordArrayList = new ArrayList<string>(new string[0]);
            SinglyLinkedList<string> wordSinglyLinkedList = new SinglyLinkedList<string>();

            Stopwatch sw = Stopwatch.StartNew();
            foreach (string word in wordList)
            {
                wordArrayList.Add(word);
            }
            sw.Stop();
            long elapsedTimeWhileAddArrayList = sw.ElapsedMilliseconds;

            sw.Restart();
            foreach (string word in wordList)
            {
                wordSinglyLinkedList.Add(word);
            }
            sw.Stop();
            long elapsedTimeWhileAddSinglyLinkedList = sw.ElapsedMilliseconds;

            Console.WriteLine("Time to add words to the Lists:");
            Console.WriteLine($"ArrayList: {elapsedTimeWhileAddArrayList} ms");
            Console.WriteLine($"SinglyLinkedList: {elapsedTimeWhileAddSinglyLinkedList} ms");


            string lastWordOfList = wordList.Last();

            sw.Restart();
            wordArrayList.Remove(lastWordOfList);
            sw.Stop();
            long elapsedTimeToRemoveLastElementFromArrayList = sw.ElapsedMilliseconds;
            sw.Restart();
            wordSinglyLinkedList.Remove(lastWordOfList);
            sw.Stop();
            long elapsedTimeToRemoveLastElementFromSinglyLinkedList = sw.ElapsedMilliseconds;

            Console.WriteLine("\nTime to remove last element from Lists:");
            Console.WriteLine($"ArrayList: {elapsedTimeToRemoveLastElementFromArrayList} ms");
            Console.WriteLine($"SinglyLinkedList: {elapsedTimeToRemoveLastElementFromSinglyLinkedList} ms");


            sw.Restart();
            var lastValue = wordArrayList[wordList.Count - 2];
            sw.Stop();
            long elapsedTimeToGetLastElementFromArrayList = sw.ElapsedTicks;

            sw.Restart();
            wordSinglyLinkedList.Remove(lastWordOfList);
            sw.Stop();
            long elapsedTimeToGetLastElementFromSinglyLinkedList = sw.ElapsedTicks;

            Console.WriteLine("\nTime to access last element of Lists:");
            Console.WriteLine($"ArrayList: {elapsedTimeToGetLastElementFromArrayList} Ticks");
            Console.WriteLine($"SinglyLinkedList: {elapsedTimeToGetLastElementFromSinglyLinkedList} Ticks");

            Console.ReadLine();
        }
    }
}
