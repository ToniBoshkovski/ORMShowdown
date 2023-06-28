using BenchmarkDotNet.Attributes;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace ORMShowdown.Benchmarks
{
    [MemoryDiagnoser(false)]
    public class QueryBenchmarks
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
        public async Task<Product?> EF_Find()
        {
            var product = await _efContext.Products.FindAsync(_product.Id);
            return product;
        }

        [Benchmark]
        public async Task<Product?> EF_FirstOrDefault()
        {
            var context = new EFCoreDbContext();
            var product = await context.Products.FirstOrDefaultAsync(x => x.Id == _product.Id);
            return product;
        }

        [Benchmark]
        public async Task<Product?> EF_FirstOrDefault_AsNoTracking()
        {
            var context = new EFCoreDbContext();
            var product = await context.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == _product.Id);
            return product;
        }

        [Benchmark]
        public async Task<Product?> EF_FirstOrDefault_Select()
        {
            var context = new EFCoreDbContext();
            var product = await context.Products.Select(b => new Product
            {
                Id = b.Id,
                Name = b.Name,
                Price = b.Price,
                Code = b.Code,
                Amount = b.Amount
            }).FirstOrDefaultAsync();

            return product;
        }

        [Benchmark]
        public async Task<Product?> EF_SingleOrDefault()
        {
            var context = new EFCoreDbContext();
            var product = await context.Products.SingleOrDefaultAsync(x => x.Id == _product.Id);
            return product;
        }

        [Benchmark]
        public async Task<Product> Dapper_FirstOrDefault()
        {
            var context = new DapperContext();
            var product = await context.CreateConnection().QueryFirstOrDefaultAsync<Product>($"SELECT * FROM Products WHERE Id = {_product.Id}");
            return product;
        }

        [Benchmark]
        public async Task<Product> Dapper_SingleOrDefault()
        {
            var context = new DapperContext();
            var product = await context.CreateConnection().QuerySingleOrDefaultAsync<Product>($"SELECT * FROM Products WHERE Id = {_product.Id}");
            return product;
        }
    }
}