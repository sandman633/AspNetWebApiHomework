using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.DTO;
using Models.Requests.Car;
using Models.Responses.Engine;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiHomework.Controllers
{
    /// <summary>
    /// Контроллер для работы с сервисом EngineService
    /// </summary>
    public class EnginesController : ControllerBase
    {
        /// <summary>
        /// Добавляем логгер, сервис и маппер
        /// </summary>
        private readonly ILogger<EnginesController> _logger;
        private readonly IEngineService _engineService;
        private readonly IMapper _mapper;
        
        /// <summary>
        /// Инициализируем поля
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="service"></param>
        /// <param name="mapper"></param>
        public EnginesController(ILogger<EnginesController> logger, IEngineService service, IMapper mapper)
        {
            _logger = logger;
            _engineService = service;
            _mapper = mapper;
        }
        /// <summary>
        /// Контроллер для получения списка двигателей
        /// </summary>
        /// <returns>
        /// Список двигателей
        /// </returns>
        [HttpGet]
        [Route("[controller]/Get")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<EngineDto>))]
        public async Task<IActionResult> GetAsync()
        {
            _logger.LogInformation("Engines/get was requested");
            var response = await _engineService.GetAsync();
            if (response != null)
            {
                return Ok(_mapper.Map<IEnumerable<EngineResponse>>(response));
            }
            return NotFound();
        }
        /// <summary>
        /// Удаление двигателей по id
        /// </summary>
        /// <param name="id">Параметр id по которому происходит поиск engine</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("[controller]/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation("Engines/id for delete was  requested");
            await _engineService.DeleteAsync(id);
            return NoContent();
        }
        /// <summary>
        /// добавление записи в бд
        /// </summary>
        /// <param name="request">запрос</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EngineResponse))]
        [Route("[controller]/add")]
        public async Task<IActionResult> PostAsync(CreateEngineRequest request)
        {
            _logger.LogInformation("Cars/Post was requested.");
            var response = await _engineService.CreateAsync(_mapper.Map<EngineDto>(request));
            return Ok(_mapper.Map<EngineResponse>(response));
        }
    }
}
