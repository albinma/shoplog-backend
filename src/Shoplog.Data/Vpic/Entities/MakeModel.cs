public partial class MakeModel
{
    public int Id { get; set; }

    public int MakeId { get; set; }

    public int ModelId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Make Make { get; set; } = null!;

    public virtual Model Model { get; set; } = null!;
}
