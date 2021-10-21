using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace Practica_2.Models
{
    public class AppDbContext : IdentityDbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Veterinaria> Veterinarias { get; set; }
        public DbSet<Noticias> Noticias { get; set; }
    }

    
}