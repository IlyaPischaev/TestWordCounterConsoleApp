using System;
using WordDataLoaderConsoleApp.Data;

namespace WordDataLoaderConsoleApp.Classes
{
    public static class DBConnectionCheck
    {
        public static bool CheckConnection()
        {
            using (WordDataDBContext db = new())
            {
                try
                {
                    db.Database.CanConnect();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Could not find database");
                    return false;
                }
                return true;
            }
        }
    }
}
