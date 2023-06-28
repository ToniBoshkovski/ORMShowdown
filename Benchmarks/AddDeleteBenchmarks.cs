using BenchmarkDotNet.Attributes;
using Dapper;

namespace ORMShowdown.Benchmarks
{
    [MemoryDiagnoser(false)]
    public class AddDeleteBenchmarks
    {
        private EFCoreDbContext _efContext = null!;
        private int lastProductId;

        [GlobalSetup]
        public void Setup()
        {
            _efContext = new();
            lastProductId = _efContext.Products.OrderByDescending(x => x.Id).First().Id;
            Console.WriteLine($"PRODUCT WITH ID --- {lastProductId}");
        }

        [Benchmark]
        public async Task EF_Add_Delete()
        {
            var context = new EFCoreDbContext();
            var newProduct = new Product
            {
                Name = Utils.CreateProductName(),
                Price = new Random().Next(1000, 10000),
                Code = Guid.NewGuid(),
                Amount = new Random().Next(1, 1000),
            };

            await context.Products.AddAsync(newProduct);
            await context.SaveChangesAsync();

            context.Products.Remove(newProduct);
            await context.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Dapper_Add_Delete()
        {
            var context = new DapperContext();
            var newProduct = new Product
            {
                Id = lastProductId + 2,
                Name = Utils.CreateProductName(),
                Price = new Random().Next(1000, 10000),
                Code = Guid.NewGuid(),
                Amount = new Random().Next(1, 1000),
            };

            await context.CreateConnection().ExecuteAsync("INSERT INTO Products (Name, Price) VALUES (@Name, @Price)", newProduct);
            await context.CreateConnection().ExecuteAsync("DELETE FROM Products WHERE Id = @Id", newProduct);
        }
    }
}