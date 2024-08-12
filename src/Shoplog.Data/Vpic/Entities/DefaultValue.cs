public partial class DefaultValue
{
    public int Id { get; set; }

    public int ElementId { get; set; }

    public int VehicleTypeId { get; set; }

    public string? DefaultValue1 { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Element Element { get; set; } = null!;

    public virtual VehicleType VehicleType { get; set; } = null!;
}
