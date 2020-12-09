
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
        /// ������������.
        /// </summary>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// ��������� ������ �������
        /// </summary>
        /// <param name="services">��������� �������� </param>
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
        /// ��������� ����������� middleware
        /// </summary>
        /// <param name="app">������������ ����������</param>
        /// <param name="env">���������� �� ����������</param>
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
