using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LocalDB
{
    public class Book
    {
        [Key] public string Isbn { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
    }
}