using Microsoft.Extensions.DependencyInjection;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Extension
{
    public static class RepositoriesConfiguration
    {
        /// <summary>
        /// Метод расширения для добавление репозитория
        /// </summary>
        /// <param name="services">сервисы</param>
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICarRepository,CarRepository>();
            services.AddScoped<IEngineRepository, EngineRepository>();
            services.AddScoped<UnitOfWork>();
        }
    }
}
