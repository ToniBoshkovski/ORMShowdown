using BenchmarkDotNet.Running;
using ORMShowdown;

var builder = WebApplication.CreateBuilder(args);

BenchmarkRunner.Run<Benchmark>();

var app = builder.Build();
app.Run();