namespace TerraMart.Domain;

public class Fee : Entity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    /// <summary>
    /// Flat-rate amount - this takes precedence over rate
    /// </summary>
    public decimal? Amount { get; set; }
    /// <summary>
    /// Amount per square meter - for fees that vary per plot size
    /// </summary>
    public decimal? Rate { get; set; }
}
