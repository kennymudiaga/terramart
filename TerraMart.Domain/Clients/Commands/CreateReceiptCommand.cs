using MediatR;

namespace TerraMart.Domain.Clients.Commands;

public class CreateReceiptCommand : IRequest<Result<Receipt>>
{
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
    /// <summary>
    /// Value date for this receipt
    /// </summary>
    public DateTime Date { get; set; }
    public List<ReceiptItem>? Items { get; set; }
}
