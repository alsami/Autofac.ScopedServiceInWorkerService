using Autofac.Extensions.DependencyInjection;
using Autofac.ScopedServiceInWorkerService;

var host = Host.CreateDefaultBuilder(args)
    // uncomment the line below to see that the exception won't appear with AutofacServiceProviderFactory registered
    // .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureServices(services =>
    {
        services
            .AddScoped<ScopedService>()
            .AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
