namespace TerraMart.Domain.Products;

public class ProductFee
{
    public string FeeId { get; set; }
    public string Title { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Rate { get; set; }
    public ProductType ProductType { get; set; }
}
