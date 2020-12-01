using APIFlowers.Database.Models;
using Microsoft.EntityFrameworkCore;
namespace APIFlowers.Database
{
    public class EFContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Status> Statuses { get; set; }
        
        public EFContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<>
        }
    }

   
}
