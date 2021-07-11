using System;
using System.Collections.Generic;
using System.Linq;
using WordCounterConsoleApp.Data;
using WordCounterConsoleApp.Interfaces;
using WordCounterConsoleApp.Models;

namespace WordCounterConsoleApp.Classes
{
    public class WordDBOptions : IWordDBOptions
    {
        public void AddWordsToDB(Dictionary<string, int> wordCountByName, int minWordCount)
        {
            using (WordDataDBContext db = new())
            {
                var words = db.Words.ToList();

                foreach (var word in words)
                {
                    if (wordCountByName.ContainsKey(word.WordName))
                    {
                        word.WordCount += wordCountByName[word.WordName];
                        wordCountByName.Remove(word.WordName);
                    }
                }

                foreach (var word in wordCountByName)
                {
                    if (word.Value >= minWordCount)
                    {
                        Word newWord = new() { WordName = word.Key, WordCount = word.Value };

                        db.Words.Add(newWord);
                    }      
                }

                db.SaveChanges();

                Console.WriteLine("All words have been successfully added to database.");
            }
        }
    }
}
