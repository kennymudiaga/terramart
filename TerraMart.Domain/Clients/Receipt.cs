namespace TerraMart.Domain.Clients;

public class Receipt
{
    /// <summary>
    /// Unique Id or number for this customer receipt
    /// </summary>
    public string ReceiptId { get; set; }
    /// <summary>
    /// Transaction reference
    /// </summary>
    public string TransactionId { get; set; }
    public decimal Amount { get; set; }
    public bool IsConfirmed { get; set; }
    public DateTime Date { get; set; }
    public string? ConfirmedBy { get; set; }
    public DateTime? DateConfirmed { get; set; }
}
