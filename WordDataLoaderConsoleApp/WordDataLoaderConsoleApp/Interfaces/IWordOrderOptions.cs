using System.Collections.Generic;
using WordDataLoaderConsoleApp.Models;

namespace WordDataLoaderConsoleApp.Interfaces
{
    public interface IWordOrderOptions
    {
        public List<Word> orderByName(List<Word> words);
        public List<Word> orderByCount(List<Word> words);
    }
}
