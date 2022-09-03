namespace TerraMart.Domain.Products;

public class ProjectPlot : Plot
{
    public string? Name { get; set; }
    /// <summary>
    /// Gets or sets a flag indicating if a client can buy half of this plot
    /// </summary>
    public bool AllowHalf { get; set; }    
    /// <summary>
    /// The total available units of this plot size
    /// </summary>
    public int? TotalUnits { get; set; }
    public decimal Price { get; set; }
    public bool IsSubscribed { get; set; }
}
