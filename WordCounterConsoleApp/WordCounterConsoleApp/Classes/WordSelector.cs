using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using WordCounterConsoleApp.Interfaces;

namespace WordCounterConsoleApp.Classes
{
    public class WordSelector : IWordSelector
    {
        private string fileContent = String.Empty;
        private string[] fileWords;
        private Dictionary<string, int> wordCount = new();

        public string[] GetWordsFromStream(StreamReader streamReader)
        {
            fileContent = streamReader.ReadToEnd();
            fileWords = Regex.Split(fileContent, @"\W|_");

            return fileWords;
        }

        public Dictionary<string, int> GetParticularWordCount(string[] words, int minWordLength, int maxWordLength)
        {
            foreach (var word in fileWords)
            {
                if ((word.Length >= minWordLength) && (word.Length <= maxWordLength))
                {
                    if (wordCount.ContainsKey(word)) wordCount[word]++;
                    else wordCount.Add(word, 1);
                }
            }

            return wordCount;
        }
    }
}
