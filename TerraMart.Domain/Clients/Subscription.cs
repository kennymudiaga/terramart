using TerraMart.Domain.Products;

namespace TerraMart.Domain.Clients;

public class Subscription : Entity
{
    public string ClientId { get; set; }
    public string ClientName { get; set; }
    public string ProjectId { get; set; }
    /// <summary>
    /// Id of the plot or housing unit
    /// </summary>
    public string ProductId { get; set; }
    public ProductType ProductType { get; set; }
    public string ProductName { get; set; }
    /// <summary>
    /// Nominal price (face-value) of the property
    /// </summary>
    public decimal Price { get; set; }
    /// <summary>
    /// Actual Amount to be paid (Price - Discounts)
    /// </summary>
    public decimal ContractAmount { get; set; }
    public decimal? Area { get; set; }
    public DateTime DateCreated { get; set; }
    public PaymentPlan? Plan { get; set; }
    public bool IsApproved { get; set; }
    public DateTime? DateApproved { get; set; }
    public string? ApprovedBy { get; set; }
    public Discount? Discount { get; set; }
    public List<Receipt>? Receipts { get; set; }
    public List<Document>? Documents { get; set; }
    public List<ProductFee>? Fees { get; set; }

    public DateTime? ExpectedCompletionDate => DateApproved?.AddMonths(Plan?.Duration ?? 0);
}
