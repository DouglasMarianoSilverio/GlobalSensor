using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GlobalSensor.Infra.Models;

public class SensorDataDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string SensorDataId { get; set; } // Identificador único no MongoDB

    public int SensorId { get; set; }
    public string Codigo { get; set; }
    public DateTimeOffset DataHoraMedicao { get; set; }
    public decimal Medicao { get; set; }
}