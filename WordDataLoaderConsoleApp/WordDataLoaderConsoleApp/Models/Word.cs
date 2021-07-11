using System.ComponentModel.DataAnnotations;

namespace WordDataLoaderConsoleApp.Models
{
    public class Word
    {
        [Key]
        public int Id { get; set; }
        public string WordName { get; set; }
        public int WordCount { get; set; }
    }
}
