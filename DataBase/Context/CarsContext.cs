using DataBase.Domain;
using DataBase.Fluent;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Context
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public class CarsContext : DbContext
    {
        /// <summary>
        /// Сущность Cars
        /// </summary>
        public DbSet<Car> Cars { get; set; }
        /// <summary>
        /// Engines
        /// </summary>
        public DbSet<Engine> Engines { get; set; }
        /// <summary>
        /// Shops
        /// </summary>
        public DbSet<Shop> Shops { get; set; }
        /// <summary>
        /// Availabilities
        /// </summary>
        public DbSet<Availability> Availabilities { get; set; }
        /// <summary>
        /// Manufacturers
        /// </summary>
        public DbSet<Manufacturer> Manufacturers { get; set; }
        /// <summary>
        /// Настройка контекста
        /// </summary>
        /// <param name="options">настройки</param>
        public CarsContext(DbContextOptions options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AvailablityConfig());
        }
    }
}
