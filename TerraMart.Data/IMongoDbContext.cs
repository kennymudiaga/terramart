using MongoDB.Driver;
using TerraMart.Domain;

namespace TerraMart.Data;

public interface IMongoDbContext
{
    IMongoDatabase Database { get; }
    IMongoCollection<T> GetCollection<T>(string collectionName) where T : Entity => Database.GetCollection<T>(collectionName);
    IMongoCollection<T> GetCollection<T>() where T : Entity => Database.GetCollection<T>(typeof(T).Name);
}

public interface IMongoDbContext<T> : IMongoDbContext
    where T : Entity
{
    IMongoCollection<T> Collection { get; }
}
