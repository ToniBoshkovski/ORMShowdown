using Microsoft.EntityFrameworkCore;

namespace ORMShowdown
{
    public class EFCoreDbContext : DbContext
    {
        public EFCoreDbContext() : base()
        { }

        public EFCoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=TONI-BOSHKOVSKI; Initial Catalog=ORMShowdown; MultipleActiveResultSets=true; Integrated Security=true; TrustServerCertificate=true;");
        }
    }
}