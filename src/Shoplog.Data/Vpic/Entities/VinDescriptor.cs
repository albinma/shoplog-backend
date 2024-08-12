public partial class VinDescriptor
{
    public int Id { get; set; }

    public string Descriptor { get; set; } = null!;

    public int ModelYear { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
