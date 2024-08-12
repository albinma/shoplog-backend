public partial class VehicleType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? DisplayOrder { get; set; }

    public int? FormType { get; set; }

    public string? Description { get; set; }

    public bool? IncludeInEquipPlant { get; set; }

    public virtual ICollection<DefaultValue> DefaultValues { get; set; } = new List<DefaultValue>();

    public virtual ICollection<Wmi> Wmis { get; set; } = new List<Wmi>();
}
