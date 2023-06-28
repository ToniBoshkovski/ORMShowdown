using BenchmarkDotNet.Attributes;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace ORMShowdown.Benchmarks
{
    [MemoryDiagnoser(false)]
    public class UpdateBenchmarks
    {
        private EFCoreDbContext _efContext = null!;
        private Product _product = null!;

        [GlobalSetup]
        public void Setup()
        {
            _efContext = new();
            var randomNum = new Random().Next(1, 99);
            _product = _efContext.Products.First(x => x.Id == randomNum);
            Console.WriteLine($"PRODUCT WITH ID --- {_product.Id}");
        }

        [Benchmark]
        public async Task EF_Update()
        {
            var context = new EFCoreDbContext();
            var product = await context.Products.FirstOrDefaultAsync(x => x.Id == _product.Id);
            product.Price = new Random().Next(1000, 10000);
            context.Products.Update(product);

            await context.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Dapper_Update()
        {
            var context = new DapperContext();
            var product = await context.CreateConnection().QueryFirstOrDefaultAsync<Product>($"SELECT * FROM Products WHERE Id = {_product.Id}");
            product.Price = new Random().Next(1000, 10000);

            await context.CreateConnection().ExecuteAsync("UPDATE Products SET Price = @Price WHERE Id = @Id", product);
        }
    }
}