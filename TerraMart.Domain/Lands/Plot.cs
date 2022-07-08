namespace TerraMart.Domain.Lands;

public class Plot
{
    /// <summary>
    /// Gets or sets a flag indicating if a client can buy half of this plot
    /// </summary>
    public bool AllowHalf { get; set; }
    /// <summary>
    /// Size in square meters
    /// </summary>
    public int Size { get; set; }
    /// <summary>
    /// The total available units of this plot size
    /// </summary>
    public int? TotalUnits { get; set; }
}
