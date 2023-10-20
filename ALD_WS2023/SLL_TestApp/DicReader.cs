using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinglyLinkedList;

namespace SLL_TestApp
{
    internal class DicReader
    {
        public static SinglyLinkedList<string> ReadDictionary()
        {
            SinglyLinkedList<string> wordList= new SinglyLinkedList<string> ();

            try
            {
                using (StreamReader reader = new StreamReader(".\\Data\\german.dic"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        wordList.Add(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Fehler beim Lesen der Datei: {e.Message}");
            }

            return wordList;
        }

    }
}
