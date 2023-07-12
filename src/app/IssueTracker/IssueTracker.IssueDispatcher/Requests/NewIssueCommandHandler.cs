using IssueTracker.Shared.Contracts.Messages;
using MassTransit;
using MediatR;

namespace IssueTracker.IssueDispatcher.Requests;

public class NewIssueCommandHandler : IRequestHandler<NewIssueCommand>
{
    private readonly IPublishEndpoint _publishEndpoint;

    public NewIssueCommandHandler(IPublishEndpoint publishEndpoint)
    {
        _publishEndpoint = publishEndpoint;
    }

    public async Task Handle(NewIssueCommand request, CancellationToken cancellationToken)
    {
        await _publishEndpoint.Publish<NewIssueMessage>(request, cancellationToken);
    }
}