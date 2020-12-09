
using AspNetWebApiHomework.Controllers;
using AspNetWebApiHomework.Swagger;
using AutoMapper;
using DataBase.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repositories;
using Repositories.Extension;
using Repositories.Interfaces;
using Services.Extension;
using Services.Services;
using System.Reflection;

namespace AspNetWebApiHomework
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// Конфигурация.
        /// </summary>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// Добавляем нужные сервисы
        /// </summary>
        /// <param name="services">Коллекция сервисов </param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureDb(Configuration);
            services.ConfigureRepositories();
            services.AddControllers();
            services.ConfigureServices();
            services.AddAutoMapper(
                typeof(CarsController).GetTypeInfo().Assembly,
                typeof(CarRepository).GetTypeInfo().Assembly);
            services.AddAutoMapper(
                typeof(EnginesController).GetTypeInfo().Assembly,
                typeof(EngineRepository).GetTypeInfo().Assembly);
            services.ConfigureSwagger();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// Настройка компонентов middleware
        /// </summary>
        /// <param name="app">Конфигурация приложения</param>
        /// <param name="env">Информация об приложении</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseCors();
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
