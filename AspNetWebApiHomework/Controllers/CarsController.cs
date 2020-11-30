﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetWebApiHomework.Swagger;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.DTO;
using Models.Requests.Car;
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
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Инициализируем поля
        /// </summary>
        /// <param name="logger">логер</param>
        /// <param name="service">сервис</param>
        /// <param name="mapper">mapper</param>
        public CarsController(ILogger<CarsController> logger, ICarService service, IMapper mapper)
        {
            _mapper = mapper;

            _logger = logger;

            _carService = service;
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
        public async Task<IActionResult>  GetAsync()
        {
            _logger.LogInformation("Cars/get was requested");
            var response = await _carService.GetAsync();
            if(response!=null)
            {
                return Ok(_mapper.Map<IEnumerable<CarResponse>>(response));
            }
            return NotFound();
        }
        [HttpGet]
        [Route("[controller]/Get/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CarDto>))]
        public async Task<IActionResult> GetAsync(long id)
        {
            _logger.LogInformation("Cars/get/id was requested");
            var response = await _carService.GetAsyncById(id);
            if (response != null)
            {
                return Ok(_mapper.Map<CarResponse>(response));
            }
            return NotFound();
        }
        /// <summary>
        /// Удаление авто по id
        /// </summary>
        /// <param name="id">Параметр id по которому происходит поиск авто</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("[controller]/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation("cars/id for delete was  requested");
            await _carService.DeleteAsync(id);
            return NoContent();
        }
        /// <summary>
        /// добавление записи в бд
        /// </summary>
        /// <param name="request">запрос</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CarResponse))]
        [Route("[controller]/add")]
        public async Task<IActionResult> PostAsync(CreateCarRequest request)
        {
            _logger.LogInformation("Cars/Post was requested.");
            var response = await _carService.CreateAsync(_mapper.Map<CarDto>(request));
            return Ok(_mapper.Map<CarResponse>(response));
        }
        /// <summary>
        /// Обновление данных
        /// </summary>
        /// <param name="request">запрос</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CarResponse))]
        public async Task<IActionResult> PutAsync(UpdateCarRequest request)
        {
            _logger.LogInformation("Cars/Put was requested.");
            var response = await _carService.UpdateAsync(_mapper.Map<CarDto>(request));
            return Ok(_mapper.Map<CarResponse>(response));
        }
    }
}
