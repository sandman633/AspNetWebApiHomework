using AspNetWebApiHomework.Controllers;
using AspNetWebApiHomework.JWT;
using AspNetWebApiHomework.Swagger;
using AutoMapper;
using DataBase.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Repositories;
using Repositories.Extension;
using Services.Extension;
using Services.Interfaces;
using Services.Services;
using System;
using System.Reflection;
using System.Text;

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
            var jwtTokenConfig = Configuration.GetSection("Jwt").Get<JwtTokenConfig>();
            services.AddSingleton(jwtTokenConfig);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = jwtTokenConfig.Issuer,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtTokenConfig.Secret)),
                    ValidAudience = jwtTokenConfig.Audience,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.FromMinutes(1)
                };
            });
            services.AddSingleton<JwtManager>();
            services.AddHostedService<JwtRefreshTokenCache>();
            services.AddScoped<IUserService, UserService>();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowJwt",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200");
                        builder.WithMethods("GET", "POST", "OPTIONS");
                        builder.AllowAnyHeader();
                        builder.SetPreflightMaxAge(TimeSpan.FromSeconds(2520));
                    });
            });
        }
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

            app.UseAuthentication();

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
