using TerraMart.Domain.Products;

namespace TerraMart.Domain.Clients
{
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
        public decimal Price { get; set; }
        public decimal? Area { get; set; }
        public DateTime DateCreated { get; set; }
        public PaymentPlan? Plan { get; set; }
        public bool IsApproved { get; set; }
        public DateTime? DateApproved { get; set; }
        public string? ApprovedBy { get; set; }

        public DateTime? ExpectedCompletionDate => DateApproved?.AddMonths(Plan?.Duration ?? 0);
    }
}
