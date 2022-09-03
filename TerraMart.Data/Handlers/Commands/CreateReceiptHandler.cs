using MediatR;
using TerraMart.Domain;
using TerraMart.Domain.Clients;
using TerraMart.Domain.Clients.Commands;

namespace TerraMart.Data.Handlers.Commands;

public class CreateReceiptHandler : IRequestHandler<CreateReceiptCommand, Result<Receipt>>
{
    readonly IMongoDbContext<Receipt> dbContext;
    public CreateReceiptHandler(IMongoDbContext<Receipt> dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<Result<Receipt>> Handle(CreateReceiptCommand request, CancellationToken cancellationToken)
    {
        var receipt = new Receipt(request);
        await dbContext.Collection.InsertOneAsync(receipt, cancellationToken: cancellationToken);
        return new(receipt);
    }
}
