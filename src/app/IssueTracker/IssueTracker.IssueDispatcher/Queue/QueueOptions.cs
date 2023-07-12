namespace IssueTracker.IssueDispatcher.Queue;

public record QueueOptions
{
    public string? RabbitMqConnectionString { get; init; }
    public string? EventHubConnectionString { get; init; }

    public bool RabbitEnabled => string.IsNullOrWhiteSpace(RabbitMqConnectionString);
    public bool EventHubEnabled => string.IsNullOrWhiteSpace(EventHubConnectionString);
}