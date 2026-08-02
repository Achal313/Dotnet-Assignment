using _29Jul.Models;
using _29Jul.Services;
using Microsoft.AspNetCore.Mvc;

namespace _29Jul.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _service;

        public VehicleController(IVehicleService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetVehicles());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var vehicle = _service.GetVehicle(id);

            if (vehicle == null)
                return NotFound("Vehicle not found");

            return Ok(vehicle);
        }

        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var vehicle = _service.GetVehicleByName(name);

            if (vehicle == null)
                return NotFound("Vehicle not found");

            return Ok(vehicle);
        }

        [HttpPost]
        public IActionResult Post(Vehicle vehicle)
        {
            var result = _service.AddVehicle(vehicle);
            return Ok(result);
        }
    }
}