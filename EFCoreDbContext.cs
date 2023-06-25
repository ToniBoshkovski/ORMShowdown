using Microsoft.EntityFrameworkCore;

namespace ORMShowdown
{
    public class EFCoreDbContext : DbContext
    {
        public EFCoreDbContext() : base()
        { }

        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=TONI-BOSHKOVSKI; Initial Catalog=ORMShowdown; MultipleActiveResultSets=true; Integrated Security=true; TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 100; i++)
            {
                var product = new Product
                {
                    Id = i,
                    Name = "Random Product",
                    Price = new Random().Next(1000, 10000)
                };

                modelBuilder.Entity<Product>().HasData(product);
            }
        }
    }
}