using GlobalSensor.Domain.Entities;
using GlobalSensor.Domain.Interfaces.Repositories;
using GlobalSensor.Infra.Configurations;
using GlobalSensor.Infra.Context;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlobalSensor.Infra.Repositories;

public class SensorDataRepository : ISensorDataRepository
{
    private readonly IMongoCollection<SensorData> _sensorDataCollection;

    
    public SensorDataRepository(MongoDbContext context)
    {
        _sensorDataCollection = context.SensorDataCollection;
    }
    public async Task<IEnumerable<SensorData>> GetAllAsync()
    {
        return await _sensorDataCollection.Find(_ => true).ToListAsync();
    }

    public async Task AddAsync(SensorData sensorData)
    {
        await _sensorDataCollection.InsertOneAsync(sensorData);
    }

}