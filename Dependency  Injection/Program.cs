using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices(
    services =>
        services.AddHostedService<Worker>()
            .AddScoped<IMessageWriter, MessageWriter>());

using var host = builder.Build();

host.Run();

// ====================================================================

public interface IMessageWriter
{
    void Write(string message);
}

public class MessageWriter : IMessageWriter
{
    public void Write(string message)
    {
        Console.WriteLine($"MessageWriter.Write(message: \"{message}\")");
    }
}

public class LoggingMessageWriter : IMessageWriter
{
    private readonly ILogger<LoggingMessageWriter> _logger;

    public LoggingMessageWriter(ILogger<LoggingMessageWriter> logger) => _logger = logger;

    public void Write(string message) => _logger.LogInformation("Info: {Msg}", message);
}

public sealed class Worker : BackgroundService
{
    private readonly IMessageWriter _messageWriter;

    public Worker(IMessageWriter messageWriter) => _messageWriter = messageWriter;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _messageWriter.Write($"Worker running at: {DateTimeOffset.Now}");
            await Task.Delay(1_000, stoppingToken);
        }
    }
}

