using IssueTracker.Shared.Enums;

namespace IssueTracker.IssueDispatcher.Requests;

public record IssueRequest(
    string Title,
    IssueLevel Level,
    DateTimeOffset OccurenceDate,
    string? Description = null,
    string? UserIdentifier = null,
    string? SessionIdentifier = null,
    string? Context = null,
    string? ModuleName = null
    );