namespace TerraMart.Domain.Products;

public class HousingUnit : Entity
{
    public string Name { get; set; }
    /// <summary>
    /// Number of storeys(floors) spanned by the apartment/house
    /// </summary>
    public int? Floors { get; set; }
    /// <summary>
    /// Numner of bedrooms included
    /// </summary>
    public int Rooms { get; set; }
    /// <summary>
    /// The total area in square meters
    /// </summary>
    public decimal? Area { get; set; }

    public HousingType Type { get; set; }

    public string? Style { get; set; }
}
