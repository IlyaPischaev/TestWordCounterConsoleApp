using System;
using WordDataLoaderConsoleApp.Classes;

namespace WordDataLoaderConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string beginningString = String.Empty;
            int wordMaxOutputAmount = 5;
            WordLoadFromDB wordLoadFromDB = new();
            WordOrderOptions wordOrderOptions = new();

            Console.WriteLine("Enter the string with witch words have to begin with:");
            beginningString = Console.ReadLine();

            var words = wordLoadFromDB.LoadData(beginningString);

            if (words.Count > 0)
            {
                words = wordOrderOptions.orderByName(words);
                words = wordOrderOptions.orderByCount(words);

                Console.WriteLine("Words list:");

                for (int i = 0; i < wordMaxOutputAmount; i++)
                {
                    Console.WriteLine($"{words[i].WordName}");
                }
            }
            else
            {
                Console.WriteLine("No such words.");
            }
        }
    }
}
