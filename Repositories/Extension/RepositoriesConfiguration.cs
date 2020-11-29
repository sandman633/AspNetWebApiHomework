using Microsoft.Extensions.DependencyInjection;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Extension
{
    public static class RepositoriesConfiguration
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICarRepository,CarRepository>();
        }
    }
}
