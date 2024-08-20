using GlobalSensor.Domain.Entities;
using GlobalSensor.Infra.Configurations;
using GlobalSensor.Infra.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlobalSensor.Infra.Context;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext(IOptions<MongoDbSettings> configurations)
    {
        var client = new MongoClient(configurations.Value.ConnectionString);
        _database = client.GetDatabase(configurations.Value.DatabaseName);
        
        CreateCollectionIfNotExists("SensorData");

    }

    public IMongoCollection<SensorDataDocument> SensorDataCollection => 
        _database.GetCollection<SensorDataDocument>("SensorData");
    
    private void CreateCollectionIfNotExists(string collectionName)
    {
        var collections = _database.ListCollectionNames().ToList();
        if (!collections.Contains(collectionName))
        {
            _database.CreateCollection(collectionName);
        }
    }

    
}