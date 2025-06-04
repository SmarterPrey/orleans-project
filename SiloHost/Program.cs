using Microsoft.Extensions.Hosting;
using Orleans;
using Orleans.Hosting;
using Grains;

Host.CreateDefaultBuilder()
    .UseOrleans(silo =>
    {
        silo.UseLocalhostClustering();
    })
    .Build()
    .Run();