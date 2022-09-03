using MediatR;
using TerraMart.Domain.Clients;
using TerraMart.Domain.Clients.Commands;

namespace TerraMart.Core.Handlers.Commands.Clients;

public class CreateReceiptHandler : IRequestHandler<CreateReceiptCommand, Receipt>
{
    public CreateReceiptHandler()
    {

    }

    public Task<Receipt> Handle(CreateReceiptCommand request, CancellationToken cancellationToken)
    {
        
    }
}
