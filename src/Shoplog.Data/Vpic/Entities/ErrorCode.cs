public partial class ErrorCode
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? AdditionalErrorText { get; set; }

    public int? Weight { get; set; }
}
