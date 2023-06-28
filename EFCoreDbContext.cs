using Microsoft.EntityFrameworkCore;
using System.Text;

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
            for (int i = 1; i <= 1000; i++)
            {
                var product = new Product
                {
                    Id = i,
                    Name = CreateProductName(),
                    Price = new Random().Next(1000, 10000),
                    Code = Guid.NewGuid(),
                    Amount = new Random().Next(1, 10000)
                };

                modelBuilder.Entity<Product>().HasData(product);
            }
        }

        public string CreateProductName()
        {
            Random rand = new Random();
            var sb = new StringBuilder();
            char letter;
            for (int i = 0; i < 15; i++)
            {
                var randValue = rand.Next(0, 26);
                letter = Convert.ToChar(randValue + 65);
                sb.Append(letter);
            }

            return sb.ToString();
        }
    }
}