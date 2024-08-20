using GlobalSensor.Domain.Entities;

namespace GlobalSensor.Domain.Interfaces.Repositories;

public interface ISensorDataRepository
{
    Task<IEnumerable<SensorData>> GetAllAsync();
    Task AddAsync(SensorData sensorData);
}