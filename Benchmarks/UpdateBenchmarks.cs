using BenchmarkDotNet.Attributes;
using Dapper;

namespace ORMShowdown.Benchmarks
{
    [MemoryDiagnoser(false)]
    public class UpdateBenchmarks
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
        public async Task EF_Update()
        {
            _product.Price = new Random().Next(1000, 10000);
            _efContext.Products.Update(_product);
            await _efContext.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Dapper_Update()
        {
            _product.Price = new Random().Next(1000, 10000);
            await _dapperContext.CreateConnection().ExecuteAsync("UPDATE Products SET Price = @Price WHERE Id = @Id", _product);
        }
    }
}