using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiHomework.Swagger
{
    /// <summary>
    /// Описывает конфигурацию сваггера
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Настраиваем документ свагера
        /// </summary>
        /// <param name="services">Коллекция сервисов для DI</param>
        public static void ConfigureSwagger(this IServiceCollection services)
        {           
            services.AddSwaggerDocument(c =>
            {
                c.Title = "Cars";
                c.DocumentName = SwaggerDocParts.Cars;
                c.ApiGroupNames = new[] { SwaggerDocParts.Cars };
                c.GenerateXmlObjects = true;
            })
            .AddSwaggerDocument(c =>
            {
                c.Title = "Engines";
                c.DocumentName = SwaggerDocParts.Engines;
                c.ApiGroupNames = new[] { SwaggerDocParts.Engines};
                c.GenerateXmlObjects = true;
            })
            .AddSwaggerDocument(c =>
            {
                c.Title = "Authorization";
                c.DocumentName = SwaggerDocParts.Accounts;
                c.ApiGroupNames = new[] { SwaggerDocParts.Accounts };
                c.GenerateXmlObjects = true;

            });
        }
    }
}
