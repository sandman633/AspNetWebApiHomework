using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DataBase.Context
{
    /// <summary>
    /// Фабрика контекста для миграций
    /// </summary>
    class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CarsContext>
    {
        /// <summary>
        /// Создание контекста для миграции
        /// </summary>
        /// <param name="args">string[] args</param>
        /// <returns>CarsContext</returns>
        public CarsContext CreateDbContext(string[] args)
        {

            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true, true)
                .AddEnvironmentVariables()
                .Build();
            var connString = conf.GetConnectionString(nameof(CarsContext));

            var options = new DbContextOptionsBuilder<CarsContext>()
                .UseNpgsql(connString, _options =>
                {
                    _options.MigrationsAssembly(typeof(CarsContext).Assembly.FullName);
                });

            return new CarsContext(options.Options);

        }
    }
}
