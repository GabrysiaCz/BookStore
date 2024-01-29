using BookStore_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore_Razor.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Kategorie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Akcja", KolejnośćWyświetlania = 1 },
                new Category { Id = 2, Name = "SciFi", KolejnośćWyświetlania = 2 },
                new Category { Id = 3, Name = "Historia", KolejnośćWyświetlania = 3 }
                );
        }
    }
}
