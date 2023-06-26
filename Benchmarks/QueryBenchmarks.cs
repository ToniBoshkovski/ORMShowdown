using BenchmarkDotNet.Attributes;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace ORMShowdown.Benchmarks
{
    [MemoryDiagnoser(false)]
    public class QueryBenchmarks
    {
        private EFCoreDbContext _efContext = null!;
        private DapperContext _dapperContext = null!;

        private Product _product = null!;

        [GlobalSetup]
        public void Setup()
        {
            _efContext = new();
            _dapperContext = new();

            var randomNum = new Random().Next(1, 99);
            _product = _efContext.Products.First(x => x.Id == randomNum);
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
            var product = await _efContext.Products.FirstOrDefaultAsync(x => x.Id == _product.Id);
            return product;
        }

        [Benchmark]
        public async Task<Product?> EF_SingleOrDefault()
        {
            var product = await _efContext.Products.SingleOrDefaultAsync(x => x.Id == _product.Id);
            return product;
        }

        [Benchmark]
        public async Task<Product> Dapper_FirstOrDefault()
        {
            var product = await _dapperContext.CreateConnection().QueryFirstOrDefaultAsync<Product>($"SELECT * FROM Products WHERE Id = {_product.Id}");
            return product;
        }

        [Benchmark]
        public async Task<Product> Dapper_SingleOrDefault()
        {
            var product = await _dapperContext.CreateConnection().QuerySingleOrDefaultAsync<Product>($"SELECT * FROM Products WHERE Id = {_product.Id}");
            return product;
        }
    }
}