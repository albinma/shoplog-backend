public partial class VinSchema
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Sourcewmi { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Notes { get; set; }

    public bool? TobeQced { get; set; }

    public virtual ICollection<Pattern> Patterns { get; set; } = new List<Pattern>();

    public virtual ICollection<WmiVinSchema> WmiVinSchemas { get; set; } = new List<WmiVinSchema>();
}
