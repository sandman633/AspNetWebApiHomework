using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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




    }
}
