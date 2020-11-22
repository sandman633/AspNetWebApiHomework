
using AspNetWebApiHomework.Swagger;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// ��������� ������ �������
        /// </summary>
        /// <param name="services">��������� �������� </param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.ConfigureServices();
            services.AddAutoMapper(typeof(CarService).GetTypeInfo().Assembly);
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
