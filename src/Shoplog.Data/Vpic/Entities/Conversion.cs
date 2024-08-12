public partial class Conversion
{
    public int Id { get; set; }

    public int FromElementId { get; set; }

    public int ToElementId { get; set; }

    public string Formula { get; set; } = null!;
}
