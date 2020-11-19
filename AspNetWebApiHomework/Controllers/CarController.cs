using System.Collections.Generic;
using AspNetWebApiHomework.Swagger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.DTO;
using Services.Interfaces;

namespace AspNetWebApiHomework.Controllers
{
    /// <summary>
    /// контроллер для взаимодействия с сервисом CarService
    /// </summary>
    [ApiController]
    [ApiExplorerSettings(GroupName = SwaggerDocParts.Cars)]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarService _carservice;

        /// <summary>
        /// инициализируем поля
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="service"></param>
        public CarController(ILogger<CarController> logger, ICarService service)
        {
            _logger = logger;

            _carservice = service;
        }
        /// <summary>
        /// контроллер для получения списка автомобилей
        /// </summary>
        /// <returns>
        /// список авто
        /// </returns>
        [HttpGet]
        [Route("[controller]/get")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CarDto>))]
        public IActionResult GetCars()
        {
            _logger.LogInformation("Cars/get was requested");
            var response = _carservice.GetCars();
            if(response!=null)
            {
                return Ok(response);
            }
            return NotFound();
        }
        /// <summary>
        /// удаление авто по id
        /// если авто с указанным айди существует проходит без ошибок, иначе not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("[controller]/{id}")]
        public IActionResult DeleteCarById(int id)
        {
            _logger.LogInformation("cars/id for delete was  requested");
            var result = _carservice.DeleteCarById(id);
            if (result)
            {
                return Ok();
            }
            else
            {
                return NotFound($"car with {id} not found");
            }
        }
    }
}
