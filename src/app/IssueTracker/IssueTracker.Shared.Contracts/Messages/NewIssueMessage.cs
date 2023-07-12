using IssueTracker.Shared.Enums;

namespace IssueTracker.Shared.Contracts.Messages;

public class NewIssueMessage
{
    private string Title { get; set; }
    private IssueLevel Level { get; set; }
    private DateTimeOffset OccurenceDate { get; set; }
    private string? Description { get; set; } = null;
    private string? UserIdentifier { get; set; } = null;
    private string? SessionIdentifier { get; set; } = null;
    private string? Context { get; set; } = null;
    private string? ModuleName { get; set; } = null;
}