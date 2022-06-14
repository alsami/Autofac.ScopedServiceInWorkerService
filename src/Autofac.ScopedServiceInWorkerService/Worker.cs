namespace Autofac.ScopedServiceInWorkerService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly ScopedService _scopedService;

    public Worker(ILogger<Worker> logger, ScopedService scopedService)
    {
        _logger = logger;
        _scopedService = scopedService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {Time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
    }
}