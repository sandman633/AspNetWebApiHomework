using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiHomework.Swagger
{
    public static class SwaggerConfiguration
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerDocument(c =>
            {
                c.Title = "Cars";
                c.DocumentName = SwaggerDocParts.Cars;
                c.ApiGroupNames = new[] { SwaggerDocParts.Cars };
                c.GenerateXmlObjects = true;
            }).AddSwaggerDocument(c => 
            {
                c.Title = "Weather";
                c.DocumentName = SwaggerDocParts.Weather;
                c.ApiGroupNames = new[] { SwaggerDocParts.Weather };
            });
        }
    }
}
