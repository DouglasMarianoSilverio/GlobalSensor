using GlobalSensor.Domain.Entities;
using GlobalSensor.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GlobalSensor.Application.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class SensorDataController : ControllerBase
{
    private readonly ISensorDataRepository _sensorDataRepository;
    
    public SensorDataController(ISensorDataRepository sensorDataRepository)
    {
        _sensorDataRepository = sensorDataRepository;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var sensorDataList = await _sensorDataRepository.GetAllAsync();
        return Ok(sensorDataList);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(SensorData sensorData)
    {
        await _sensorDataRepository.AddAsync(sensorData);
        return Ok();
    }

}