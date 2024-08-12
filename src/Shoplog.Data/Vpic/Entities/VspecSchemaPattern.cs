public partial class VspecSchemaPattern
{
    public int Id { get; set; }

    public int SchemaId { get; set; }

    public virtual VehicleSpecSchema Schema { get; set; } = null!;
}
