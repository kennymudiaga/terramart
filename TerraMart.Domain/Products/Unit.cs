namespace TerraMart.Domain.Products;

/// <summary>
/// Represents a standard sellable lot-size of land
/// </summary>
public class Unit : Entity
{
    /// <summary>
    /// Optional description for this plot size
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// Plot size in square meters
    /// </summary>
    public int Size { get; set; }
}
