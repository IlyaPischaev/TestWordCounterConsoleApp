using System.Collections.Generic;
using System.Linq;
using WordDataLoaderConsoleApp.Data;
using WordDataLoaderConsoleApp.Interfaces;
using WordDataLoaderConsoleApp.Models;

namespace WordDataLoaderConsoleApp.Classes
{
    public class WordLoadFromDB : IWordLoadFromDB
    {
        public List<Word> LoadData(string beginningString)
        {
            if (DBConnectionCheck.CheckConnection())
            {
                using (WordDataDBContext db = new())
                {
                    var words = db.Words.ToList().Where(word => word.WordName.StartsWith(beginningString)).ToList();

                    return words;
                }
            }
            return null;
        }
    }
}
