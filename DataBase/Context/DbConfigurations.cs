using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataBase.Context
{
    public static class DbConfigurations
    {
        /// <summary>
        /// Метод расширения для добавления контекста базы данных
        /// </summary>
        /// <param name="service">сервисы</param>
        /// <param name="configuration">конфигурация</param>
        public static void ConfigureDb(this IServiceCollection service, IConfiguration configuration )
        {
            service.AddDbContext<CarsContext>(
                options => options
                .UseNpgsql(configuration.GetConnectionString(nameof(CarsContext)),
                builder => builder.MigrationsAssembly(typeof(CarsContext).Assembly.FullName)));
        }
    }
}
