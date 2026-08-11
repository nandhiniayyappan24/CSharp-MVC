namespace CSharpMvc.Models;

public sealed class HomeViewModel
{
    public string Title { get; set; } = string.Empty;
    public string Framework { get; set; } = string.Empty;
}

public sealed class ErrorViewModel
{
    public string RequestId { get; set; } = string.Empty;
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
