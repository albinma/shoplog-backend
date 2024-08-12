public partial class Model
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<MakeModel> MakeModels { get; set; } = new List<MakeModel>();
}
