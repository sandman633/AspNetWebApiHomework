using System.Collections.Generic;
using AspNetWebApiHomework.Swagger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.DTO;
using Services.Interfaces;

namespace AspNetWebApiHomework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = SwaggerDocParts.Cars)]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarService _carservice;


        public CarController(ILogger<CarController> logger, ICarService service)
        {
            _logger = logger;

            _carservice = service;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CarDto>))]
        public IActionResult GetCars()
        {
            _logger.LogInformation("Cars/get was requested");
            var response = _carservice.GetCars();
            return Ok(response);
        }
    }
}
