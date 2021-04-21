using System;
using System.Collections.Generic;

namespace CloudDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using CloudAuthorContext ctx = new CloudAuthorContext();

            List<Book> books = new List<Book>();
            Book b1 = new()
            {
                Isbn = "1234567890",
                Title = "Rythm of War",
                PageCount = 1234
            };

            Book b2 = new()
            {
                Isbn = "56789012345",
                Title = "Starsight",
                PageCount = 365
            };
            books.Add(b1);
            books.Add(b2);
            Author a1 = new Author
            {
                FirstName = "Brandon",
                LastName = "Sanderson",
                Books = books
            };

            ctx.Authors.Add(a1);
            ctx.SaveChanges();
        }
    }
}