using GlobalSensor.Domain.Entities;
using GlobalSensor.Infra.Models;

namespace GlobalSensor.Infra.Mapper;

public static class SensorDataMapper
{
    public static SensorDataDocument ToDocument(SensorData sensorData)
    {
        return new SensorDataDocument
        {
            SensorId = sensorData.Id,
            Codigo = sensorData.Codigo,
            DataHoraMedicao = sensorData.DataHoraMedicao,
            Medicao = sensorData.Medicao
        };
    }

    public static SensorData ToDomain(SensorDataDocument document)
    {
        return new SensorData
        {
            Id = document.SensorId,
            Codigo = document.Codigo,
            DataHoraMedicao = document.DataHoraMedicao,
            Medicao = document.Medicao
        };
    }
}