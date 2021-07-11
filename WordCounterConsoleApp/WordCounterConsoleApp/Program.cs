using System;
using System.Collections.Generic;
using System.IO;
using WordCounterConsoleApp.Classes;

namespace WordCounterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = String.Empty;
            Dictionary<string, int> wordCountByName = new();
            string[] words;
            int minWordLength = 3;
            int maxWordLength = 20;
            int minWordCount = 4;

            WordSelector wordSelector = new();
            WordDBOptions wordDBOptions = new();

            Console.WriteLine("Write file's path:");
            filePath = Console.ReadLine();

            StreamReader streamReader = TextFileStreamReaderResult.GetStream(filePath);

            if (streamReader!=null)
            {
                words = wordSelector.GetWordsFromStream(streamReader);
                wordCountByName = wordSelector.GetParticularWordCount(words, minWordLength, maxWordLength);

                wordDBOptions.AddWordsToDB(wordCountByName, minWordCount);
            }

        }
    }
}
