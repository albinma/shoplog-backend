public partial class VehicleSpecPattern
{
    public int Id { get; set; }

    public int VspecSchemaPatternId { get; set; }

    public bool IsKey { get; set; }

    public int ElementId { get; set; }

    public string AttributeId { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Element Element { get; set; } = null!;
}
