using BenchmarkDotNet.Attributes;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace ORMShowdown.Benchmarks
{
    [MemoryDiagnoser(false)]
    public class QueryAllBenchmarks
    {
        [Benchmark]
        public async Task<List<Product>> EF_ToList()
        {
            var context = new EFCoreDbContext();
            var products = await context.Products.ToListAsync();
            return products;
        }

        [Benchmark]
        public async Task<List<Product>> EF_ToList_AsNoTracking()
        {
            var context = new EFCoreDbContext();
            var products = await context.Products.AsNoTracking().ToListAsync();
            return products;
        }

        [Benchmark]
        public async Task<List<Product>> EF_FromSql_ToList()
        {
            var context = new EFCoreDbContext();
            var products = await context.Products.FromSql($"SELECT * FROM Products").ToListAsync();
            return products;
        }

        [Benchmark]
        public async Task<List<Product>> Dapper_ToList()
        {
            var context = new DapperContext();
            var products = (await context.CreateConnection().QueryAsync<Product>("SELECT * FROM Products")).ToList();
            return products;
        }
    }
}