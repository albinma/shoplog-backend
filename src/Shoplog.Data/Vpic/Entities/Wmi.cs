public partial class Wmi
{
    public int Id { get; set; }

    public string Wmi1 { get; set; } = null!;

    public int? ManufacturerId { get; set; }

    public int? MakeId { get; set; }

    public int? VehicleTypeId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CountryId { get; set; }

    public DateTime? PublicAvailabilityDate { get; set; }

    public int? TruckTypeId { get; set; }

    public DateTime? ProcessedOn { get; set; }

    public bool? NonCompliant { get; set; }

    public string? NonCompliantReason { get; set; }

    public bool? NonCompliantSetByOvsc { get; set; }

    public virtual Manufacturer? Manufacturer { get; set; }

    public virtual VehicleType? VehicleType { get; set; }

    public virtual ICollection<WmiVinSchema> WmiVinSchemas { get; set; } = new List<WmiVinSchema>();

    public virtual ICollection<Make> Makes { get; set; } = new List<Make>();
}
