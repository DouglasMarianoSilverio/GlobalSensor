using GlobalSensor.Domain.Entities;
using GlobalSensor.Infra.Configurations;
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
    }

    public IMongoCollection<SensorData> SensorDataCollection => 
        _database.GetCollection<SensorData>("SensorData");

    
}