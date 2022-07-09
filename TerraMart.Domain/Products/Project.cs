namespace TerraMart.Domain.Products;

public class Project : Entity
{
    public string? Name { get; set; }
    public string? Caption { get; set; }
    public string? Description { get; set; }
    public List<ProjectPlot>? Plots { get; set; }
    public List<ProjectHousing>? Houses { get; set; }
    public List<ProductFee>? Fees { get; set; }
    public DateTime DateCreated { get; set; }
    public bool IsAvailable { get; set; }
    public List<MileStone>? MileStones { get;set; }
    public List<Document>? Media { get; set; }
    public string? Country { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }
    public string? GeoLocation { get; set; }
    public Discount? Discount { get; set; }
}
