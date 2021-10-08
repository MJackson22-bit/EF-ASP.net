using Microsoft.EntityFrameworkCore;
namespace Practica_2.Models
{
    public class AppDbContext : DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
    }

    
}