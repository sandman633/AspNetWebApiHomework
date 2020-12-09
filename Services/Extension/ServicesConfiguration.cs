using Microsoft.Extensions.DependencyInjection;
using Repositories.Interfaces;
using Services.Interfaces;
using Services.Services;

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
            services.AddTransient<IEngineService, EngineService>();
        }
    }
}
