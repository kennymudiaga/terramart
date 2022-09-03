using FluentValidation;
using TerraMart.Domain.Clients.Commands;

namespace TerraMart.Core.Validators.Clients;

public class ReceiptValidator : AbstractValidator<CreateReceiptCommand>
{
    public ReceiptValidator(ReceiptItemValidator itemsValidator)
    {
        RuleFor(x => x.ReceiptId).NotEmpty().MaximumLength(20);
        RuleFor(x => x.TransactionId).NotEmpty().MaximumLength(20);
        RuleFor(x => x.Amount).GreaterThan(0);
        RuleFor(x => x.Date).NotEqual(DateTime.MinValue).WithMessage(Messages.DefaultDateError);
        RuleFor(x => x.Items).ForEach(item => item.SetValidator(itemsValidator));
    }
}
