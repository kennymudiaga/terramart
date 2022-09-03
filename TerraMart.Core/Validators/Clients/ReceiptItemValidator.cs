using FluentValidation;
using TerraMart.Domain.Clients;

namespace TerraMart.Core.Validators.Clients;

public class ReceiptItemValidator : AbstractValidator<ReceiptItem>
{
    public ReceiptItemValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MaximumLength(200);
        RuleFor(x=>x.FeeId).NotEmpty();
        RuleFor(x => x.Amount).NotEmpty();
    }
}
