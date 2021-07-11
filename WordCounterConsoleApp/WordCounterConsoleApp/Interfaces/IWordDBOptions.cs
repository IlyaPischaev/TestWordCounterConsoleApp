using System.Collections.Generic;

namespace WordCounterConsoleApp.Interfaces
{
    interface IWordDBOptions
    {
        public void AddWordsToDB(Dictionary<string, int> wordCountByName, int minWordCount);
    }
}
