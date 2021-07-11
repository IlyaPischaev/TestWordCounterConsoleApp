using System.Collections.Generic;
using WordDataLoaderConsoleApp.Models;

namespace WordDataLoaderConsoleApp.Interfaces
{
    interface IWordLoadFromDB
    {
        public List<Word> LoadData(string beginningString);
    }
}
