using Microsoft.AspNetCore.Mvc;

namespace GlobalSensor.Application.Api.Controllers;

public class SensorDataController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}