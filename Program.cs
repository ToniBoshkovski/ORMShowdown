using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using Microsoft.EntityFrameworkCore;
using ORMShowdown;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<DapperContext>();

var config = new ManualConfig()
        .WithOptions(ConfigOptions.DisableOptimizationsValidator)
        .AddValidator(JitOptimizationsValidator.DontFailOnError)
        .AddLogger(ConsoleLogger.Default)
        .AddColumnProvider(DefaultColumnProviders.Instance);

BenchmarkRunner.Run<QueryBenchmarks>(config);
//BenchmarkRunner.Run<UpdateBenchmarks>(config);
//BenchmarkRunner.Run<AddDeleteBenchmarks>(config);

var app = builder.Build();
app.Run();