namespace TerraMart.Domain.Products;

public class PaymentPlan
{
    /// <summary>
    /// Duration in months
    /// </summary>
    public int Duration { get; set; }
    /// <summary>
    /// Flat rate interest amount for this plan - takes precedence over rate.
    /// </summary>
    public decimal? Interest { get; set; }
    /// <summary>
    /// Annualized interest rate for this payment plan
    /// </summary>
    public decimal? Rate { get; set; }
}
