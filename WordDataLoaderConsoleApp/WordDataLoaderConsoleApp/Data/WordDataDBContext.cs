using Microsoft.EntityFrameworkCore;
using WordDataLoaderConsoleApp.Models;

namespace WordDataLoaderConsoleApp.Data
{
    public class WordDataDBContext : DbContext
    {
        public WordDataDBContext()
        {
        }

        public DbSet<Word> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=WordCounterDB;Trusted_Connection=true");
            }
        }
    }
}
