using Microsoft.EntityFrameworkCore;
using WordCounterConsoleApp.Models;

namespace WordCounterConsoleApp.Data
{
    public class WordDataDBContext : DbContext
    {
        public WordDataDBContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WordCounterDB;Trusted_Connection=true");
        }

        public DbSet<Word> Words { get; set; }
    }
}
