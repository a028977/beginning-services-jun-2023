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