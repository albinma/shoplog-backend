public partial class Pattern
{
    public int Id { get; set; }

    public int VinSchemaId { get; set; }

    public string Keys { get; set; } = null!;

    public int ElementId { get; set; }

    public string AttributeId { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Element Element { get; set; } = null!;

    public virtual VinSchema VinSchema { get; set; } = null!;
}
