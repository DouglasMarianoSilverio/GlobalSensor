namespace GlobalSensor.Domain.Entities;

public class SensorData
{
    public int Id { get; set; }
    public string Codigo { get; set; }
    public DateTimeOffset DataHoraMedicao { get; set; }
    public decimal Medicao { get; set; }
}