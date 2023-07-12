using IssueTracker.Shared.Contracts.Messages;
using MassTransit;

namespace IssueTracker.IssueConsumer.Queue;

public class NewIssueMessageHandler : IConsumer<NewIssueMessage>
{
    public async Task Consume(ConsumeContext<NewIssueMessage> context)
    {
        Console.WriteLine(context.Message.Title);
    }
}