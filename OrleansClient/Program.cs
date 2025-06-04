using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orleans;
using Grains;

using var host = Host.CreateDefaultBuilder()
    .UseOrleansClient(client =>
    {
        client.UseLocalhostClustering();
    })
    .Build();

await host.StartAsync();

var client = host.Services.GetRequiredService<IGrainFactory>();

var grain = client.GetGrain<ICounterGrain>("user123");
Console.WriteLine($"Initial count: {await grain.GetCount()}");

Console.WriteLine("Incrementing...");
Console.WriteLine($"New count: {await grain.Increment()}");

await host.StopAsync();