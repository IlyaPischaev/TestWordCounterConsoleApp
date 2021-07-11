using System.Collections.Generic;
using System.Linq;
using WordDataLoaderConsoleApp.Interfaces;
using WordDataLoaderConsoleApp.Models;

namespace WordDataLoaderConsoleApp.Classes
{
    public class WordOrderOptions : IWordOrderOptions
    {
        public List<Word> orderByName(List<Word> words)
        {
            words = words.OrderBy(word => word.WordName).ToList();

            return words;
        }

        public List<Word> orderByCount(List<Word> words)
        {
            words = words.OrderByDescending(word => word.WordCount).ToList();

            return words;
        }
    }
}
