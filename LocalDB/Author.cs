using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LocalDB
{
    public class Author
    {
        [Key] public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}