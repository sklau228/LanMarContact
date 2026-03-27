using Microsoft.EntityFrameworkCore;
using ContactManagerLanMar.Models;

namespace ContactManagerLanMar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .HasIndex(c => new { c.FirstName, c.LastName, c.Email });
        }
    }
}