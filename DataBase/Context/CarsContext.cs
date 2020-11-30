using DataBase.Domain;
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
        DbSet<Car> Cars { get; set; }
        /// <summary>
        /// Engines
        /// </summary>
        DbSet<Engine> Engines { get; set; }
        /// <summary>
        /// Shops
        /// </summary>
        DbSet<Shop> Shops { get; set; }
        /// <summary>
        /// Availabilities
        /// </summary>
        DbSet<Availability> Availabilities { get; set; }
        /// <summary>
        /// 
        /// </summary>
        DbSet<Manufacturer> Manufacturers { get; set; }
        /// <summary>
        /// Настройка контекста
        /// </summary>
        /// <param name="options">настройки</param>
        public CarsContext(DbContextOptions options):base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
