public partial class WmiVinSchema
{
    public int Id { get; set; }

    public int WmiId { get; set; }

    public int VinSchemaId { get; set; }

    public int YearFrom { get; set; }

    public int? YearTo { get; set; }

    public int? OrgId { get; set; }

    public virtual VinSchema VinSchema { get; set; } = null!;

    public virtual Wmi Wmi { get; set; } = null!;
}
