using System.Runtime.InteropServices;

namespace IssueTrackerApi.Models;

public record IssueCreatedRequest
{
    public string From { get; init; } = String.Empty;
    public string Issue { get; init; } = String.Empty;
}

public record IssueCreatedResponse
{
    public Guid Id { get; init; } = Guid.Empty;
    public string From { get; init; } = String.Empty;
    public string Issue { get; init; } = String.Empty;
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset? ClosedAt { get; init; }
}

public record IssueCreatedResponseWithSupportInfo
{
    public IssueCreatedResponse Issue { get; init; } = new();
    public SupportModel Support { get; init; } = new();
}

public record SupportModel
{
    public string SupportNumber { get; init; } = String.Empty;
    public bool IsOpenNow { get; init; }
    public DateTime? OpensAt { get; init; }
}