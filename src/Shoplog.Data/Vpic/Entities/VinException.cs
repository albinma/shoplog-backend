public partial class VinException
{
    public int Id { get; set; }

    public string Vin { get; set; } = null!;

    public bool CheckDigit { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
