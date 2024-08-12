public partial class GrossVehicleWeightRating
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? SortOrder { get; set; }

    public int? MinRangeWeight { get; set; }

    public int? MaxRangeWeight { get; set; }
}
