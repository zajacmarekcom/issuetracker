using IssueTracker.Shared.Enums;

namespace IssueTracker.Shared.Contracts.Messages;

public class NewIssueMessage
{
    public string Title { get; set; }
    public IssueLevel Level { get; set; }
    public DateTimeOffset OccurenceDate { get; set; }
    public string? Description { get; set; } = null;
    public string? UserIdentifier { get; set; } = null;
    public string? SessionIdentifier { get; set; } = null;
    public string? Context { get; set; } = null;
    public string? ModuleName { get; set; } = null;
}