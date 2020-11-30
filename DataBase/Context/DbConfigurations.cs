using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataBase.Context
{
    public static class DbConfigurations
    {
        public static void ConfigureDb(this IServiceCollection service, IConfiguration configuration )
        {
            service.AddDbContext<CarsContext>(
                options => options
                .UseNpgsql(configuration.GetConnectionString(nameof(CarsContext)),
                builder => builder.MigrationsAssembly(typeof(CarsContext).Assembly.FullName)));
        }
    }
}
