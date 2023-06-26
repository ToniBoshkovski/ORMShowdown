using BenchmarkDotNet.Attributes;
using Dapper;

namespace ORMShowdown
{
    [MemoryDiagnoser(false)]
    public class AddDeleteBenchmarks
    {
        private EFCoreDbContext _efContext = null!;

        private DapperContext _dapperContext = null!;

        private int lastProductId;

        [GlobalSetup]
        public void Setup()
        {
            _efContext = new();
            _dapperContext = new();

            lastProductId = _efContext.Products.OrderByDescending(x => x.Id).First().Id;
        }

        [Benchmark]
        public async Task EF_Add_Delete()
        {
            var newProduct = new Product
            {
                Name = "Random Product",
                Price = new Random().Next(1000, 10000)
            };

            await _efContext.Products.AddAsync(newProduct);
            await _efContext.SaveChangesAsync();

            _efContext.Products.Remove(newProduct);
            await _efContext.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Dapper_Add_Delete()
        {
            var newProduct = new Product
            {
                Id = lastProductId + 2,
                Name = "Random Product",
                Price = new Random().Next(1000, 10000)
            };

            await _dapperContext.CreateConnection().ExecuteAsync("INSERT INTO Products (Name, Price) VALUES (@Name, @Price)", newProduct);
            await _dapperContext.CreateConnection().ExecuteAsync("DELETE FROM Products WHERE Id = @Id", newProduct);
        }
    }
}