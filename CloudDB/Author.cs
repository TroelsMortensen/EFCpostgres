using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CloudDB
{
    public class Author
    {
        [Key] public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}