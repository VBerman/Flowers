using APIFlowers.Database.Models;
using Microsoft.EntityFrameworkCore;
namespace APIFlowers.Database
{
    public class EFContext : DbContext
    {
        //TODO check data dictionary
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<OrderService> OrderServices { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<FlowerKind> FlowerKinds { get; set; }
        public DbSet<Revision> Revisions { get; set; }
        public DbSet<RevisionFlower> RevisionFlowers{ get; set; }
        public DbSet<WinterHardiness> WinterHardinesses { get; set; }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<FlowerBalance> FlowerBalances { get; set; }
        public DbSet<Bouquet> Bouquets { get; set; }
        public DbSet<BouquetFlower> BouquetFlowers { get; set; }
        public DbSet<FlowerArea> FlowerAreas { get; set; }
        public DbSet<FlowerAreaFlower> FlowerAreaFlowers { get; set; }
        public DbSet<OrderFlower> OrderFlowers { get; set; }
        public DbSet<Aroma> Aromas { get; set; }
        
        public EFContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderService>().HasKey(c => new { c.OrderId, c.ServiceId });
            modelBuilder.Entity<FlowerBalance>().HasKey(c => new { c.FlowerId, c.Date});
            modelBuilder.Entity<OrderFlower>().HasKey(c => new { c.FlowerId, c.OrderId});
            modelBuilder.Entity<BouquetFlower>().HasKey(c => new { c.BouquetId, c.FlowerId});
            modelBuilder.Entity<FlowerAreaFlower>().HasKey(c => new { c.FlowerAreaId, c.Row, c.Column});
            modelBuilder.Entity<RevisionFlower>().HasKey(c => new { c.FlowerId, c.RevisionId});
        }
    }


}
