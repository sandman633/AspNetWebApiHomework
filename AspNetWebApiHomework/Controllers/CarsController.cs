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
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;
        private readonly ICarService _carservice;

        /// <summary>
        /// Инициализируем поля
        /// </summary>
        /// <param name="logger">добавляем логер</param>
        /// <param name="service">и сервис</param>
        public CarsController(ILogger<CarsController> logger, ICarService service)
        {
            _logger = logger;

            _carservice = service;
        }
        /// <summary>
        /// Контроллер для получения списка автомобилей
        /// </summary>
        /// <returns>
        /// Список авто
        /// </returns>
        [HttpGet]
        [Route("[controller]/Get")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CarDto>))]
        public IActionResult Get()
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
        /// Удаление авто по id
        /// если авто с указанным айди существует проходит без ошибок, иначе not found
        /// </summary>
        /// <param name="id">Параметр id по которому происходит поиск авто</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("[controller]/{id}")]
        public IActionResult Delete(int id)
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
