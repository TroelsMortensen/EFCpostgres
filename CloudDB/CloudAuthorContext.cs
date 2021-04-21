using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CloudDB
{
    public class CloudAuthorContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=hattie.db.elephantsql.com;Port=5432;Database=uwzacipi;Username=uwzacipi;Password=UgQ8ULFVvK761hpzCs313j9bmdr02Xdr",
                options => options.UseAdminDatabase("uwzacipi"));
        }
    }
}