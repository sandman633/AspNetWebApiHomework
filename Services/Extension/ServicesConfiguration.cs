using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Extension
{
    /// <summary>
    /// Метод расширения для настройки конфигурации сервиса
    /// </summary>
    public static class ServicesConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<ICarService, CarService>();
        }
    }
}
