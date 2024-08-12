public partial class Manufacturer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Wmi> Wmis { get; set; } = new List<Wmi>();
}
