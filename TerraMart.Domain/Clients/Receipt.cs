using TerraMart.Domain.Clients.Commands;

namespace TerraMart.Domain.Clients;

public class Receipt : Entity
{
    private Receipt()
    {
        Items = new List<ReceiptItem>();
        TimeStamp = DateTime.UtcNow;
    }

    public Receipt(CreateReceiptCommand receiptCommand)
    {
        Items = receiptCommand.Items!;
        ReceiptId = receiptCommand.ReceiptId;
        TransactionId = receiptCommand.TransactionId;
        Amount = receiptCommand.Amount;
        Date = receiptCommand.Date;
        TimeStamp = DateTime.UtcNow;
    }

    /// <summary>
    /// Unique Id or number for this customer receipt
    /// </summary>
    public string? ReceiptId { get; set; }
    /// <summary>
    /// Transaction reference
    /// </summary>
    public string? TransactionId { get; set; }
    public decimal Amount { get; set; }
    public bool IsConfirmed { get; set; }
    public DateTime TimeStamp { get; set; }
    /// <summary>
    /// Value date for this receipt
    /// </summary>
    public DateTime Date { get; set; }
    public string? ConfirmedBy { get; set; }
    public DateTime? DateConfirmed { get; set; }
    public List<ReceiptItem> Items { get; private set; }
}
