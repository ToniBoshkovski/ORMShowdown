using BenchmarkDotNet.Attributes;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace ORMShowdown
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        private readonly EFCoreDbContext _efContext;
        private readonly DapperContext _dapperContext;
        private const int Iterations = 1000;

        public Benchmark(EFCoreDbContext efContext, DapperContext dapperContext)
        {
            _efContext = efContext;
            _dapperContext = dapperContext;
        }

        [Benchmark]
        public void EFCoreQueryBenchmark()
        {
            for (int i = 0; i < Iterations; i++)
            {
                var products = _efContext.Products.ToList();
            }
        }

        [Benchmark]
        public void DapperQueryBenchmark()
        {
            for (int i = 0; i < Iterations; i++)
            {
                var products = _dapperContext.CreateConnection().Query<Product>("SELECT * FROM Products").ToList();
            }
        }

        [Benchmark]
        public void EFCoreUpdateBenchmark()
        {
            for (int i = 0; i < Iterations; i++)
            {
                var product = _efContext.Products.FirstOrDefault();
                if (product != null)
                {
                    product.Price = 10;
                    _efContext.SaveChanges();
                }
            }
        }

        [Benchmark]
        public void DapperUpdateBenchmark()
        {
            for (int i = 0; i < Iterations; i++)
            {
                var product = _dapperContext.CreateConnection().QueryFirstOrDefault<Product>("SELECT TOP(1) * FROM Products");
                if (product != null)
                {
                    product.Price = 10;
                    _dapperContext.CreateConnection().Execute("UPDATE Products SET Price = @Price WHERE Id = @Id", product);
                }
            }
        }
    }
}