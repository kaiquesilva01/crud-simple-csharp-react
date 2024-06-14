using Microsoft.EntityFrameworkCore;
using WebKaiqueCrud.Models;

namespace WebKaiqueCrud.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { 
                        Id = 1,
                        name = "Maria Rocha",
                        email = "mariarocha@gmail.com",
                        age = 30
                
                },
                new User {
                        Id = 2,
                        name = "Matheus Pereira",
                        email = "matheuspereira@gmail.com",
                        age = 20
                }
                );
        }
    }
}
