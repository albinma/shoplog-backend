public partial class Element
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Code { get; set; }

    public string? LookupTable { get; set; }

    public string? Description { get; set; }

    public bool? IsPrivate { get; set; }

    public string? GroupName { get; set; }

    public string? DataType { get; set; }

    public int? MinAllowedValue { get; set; }

    public int? MaxAllowedValue { get; set; }

    public bool? IsQs { get; set; }

    public string? Decode { get; set; }

    public int? Weight { get; set; }

    public virtual ICollection<DefaultValue> DefaultValues { get; set; } = new List<DefaultValue>();

    public virtual ICollection<Pattern> Patterns { get; set; } = new List<Pattern>();

    public virtual ICollection<VehicleSpecPattern> VehicleSpecPatterns { get; set; } =
        new List<VehicleSpecPattern>();
}
