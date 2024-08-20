using GlobalSensor.Domain.Entities;
using GlobalSensor.Domain.Interfaces.Repositories;
using GlobalSensor.Infra.Configurations;
using GlobalSensor.Infra.Context;
using GlobalSensor.Infra.Mapper;
using GlobalSensor.Infra.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlobalSensor.Infra.Repositories;

public class SensorDataRepository : ISensorDataRepository
{
    private readonly IMongoCollection<SensorDataDocument> _sensorDataCollection;

    
    public SensorDataRepository(MongoDbContext context)
    {
        _sensorDataCollection = context.SensorDataCollection;
    }
    public async Task<IEnumerable<SensorData>> GetAllAsync()
    {
        var documents = await _sensorDataCollection.Find(_ => true).ToListAsync();
        return documents.Select(SensorDataMapper.ToDomain);
    }

    public async Task AddAsync(SensorData sensorData)
    {
        var document = SensorDataMapper.ToDocument(sensorData);

        await _sensorDataCollection.InsertOneAsync(document);
    }

}