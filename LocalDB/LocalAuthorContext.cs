using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LocalDB
{
    public class LocalAuthorContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=LocalAuthor;Username=postgres;Password=TroelsDatabase",
                options => options.UseAdminDatabase("LocalAuthor"));
        }
    }
}