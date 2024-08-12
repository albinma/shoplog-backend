public partial class EngineModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<EngineModelPattern> EngineModelPatterns { get; set; } =
        new List<EngineModelPattern>();
}
