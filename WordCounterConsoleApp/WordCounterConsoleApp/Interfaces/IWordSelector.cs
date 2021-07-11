using System.Collections.Generic;
using System.IO;

namespace WordCounterConsoleApp.Interfaces
{
    interface IWordSelector
    {
        public string[] GetWordsFromStream(StreamReader streamReader);
        public Dictionary<string, int> GetParticularWordCount(string[] words, int minWordLength, int maxWordLength);
    }
}
