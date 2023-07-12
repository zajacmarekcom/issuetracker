using IssueTracker.Shared.Enums;
using MediatR;

namespace IssueTracker.IssueDispatcher.Requests;

public record NewIssueCommand(
    string Title,
    IssueLevel Level,
    DateTimeOffset OccurenceDate,
    string? Description = null,
    string? UserIdentifier = null,
    string? SessionIdentifier = null,
    string? Context = null,
    string? ModuleName = null
    ) : IRequest;