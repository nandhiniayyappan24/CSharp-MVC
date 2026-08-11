namespace CSharpMvc.Models;

public sealed record HomeViewModel
{
    public string Title { get; init; } = string.Empty;
    public string Framework { get; init; } = string.Empty;
}

public sealed record ErrorViewModel
{
    public string? RequestId { get; init; }
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
