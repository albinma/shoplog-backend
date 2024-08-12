public partial class VehicleSpecSchema
{
    public int Id { get; set; }

    public int MakeId { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? VehicleTypeId { get; set; }

    public string? Source { get; set; }

    public DateTime? SourceDate { get; set; }

    public string? Url { get; set; }

    public bool? TobeQced { get; set; }

    public virtual ICollection<VspecSchemaPattern> VspecSchemaPatterns { get; set; } =
        new List<VspecSchemaPattern>();
}
