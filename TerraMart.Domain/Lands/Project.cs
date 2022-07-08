namespace TerraMart.Domain.Lands;

public class Project : Entity
{
    public string? Name { get; set; }
    public string? Caption { get; set; }
    public string? Description { get; set; }
    public List<Plot>? Plots { get; set; }
    public DateTime DateCreated { get; set; }
    public bool IsAvailable { get; set; }
}
