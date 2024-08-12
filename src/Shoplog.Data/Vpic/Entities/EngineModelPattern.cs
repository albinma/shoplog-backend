public partial class EngineModelPattern
{
    public int Id { get; set; }

    public int EngineModelId { get; set; }

    public int ElementId { get; set; }

    public string AttributeId { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual EngineModel EngineModel { get; set; } = null!;
}
