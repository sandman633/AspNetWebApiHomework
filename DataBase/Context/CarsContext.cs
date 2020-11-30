using DataBase.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Context
{
    /// <summary>
    /// 
    /// </summary>
    class CarsContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        DbSet<Car> Cars { get; set; }
        /// <summary>
        /// 
        /// </summary>
        DbSet<Engine> Engines { get; set; }
        /// <summary>
        /// 
        /// </summary>
        DbSet<Shop> Shops { get; set; }
        /// <summary>
        /// 
        /// </summary>
        DbSet<Availability> Availabilities { get; set; }
        /// <summary>
        /// 
        /// </summary>
        DbSet<Manufacturer> Manufacturers { get; set; }
        public CarsContext(DbContextOptions options):base(options)
        {

        }
    }
}
