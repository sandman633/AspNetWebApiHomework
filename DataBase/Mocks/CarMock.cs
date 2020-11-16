using DataBase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Mocks
{
    public static class CarMock
    {
        public static IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car { Id=1, Brand = "KIA Motors", Model = "Rio",Year = 2020, EngineType = "Rio 1.6", MaxSpeed = 198, Type = "Sedan"},
                new Car { Id=2, Brand = "Audi", Model = "A6", Year = 2018, EngineType = "V6", MaxSpeed = 250, Type = "Sedan"},
                new Car { Id=3, Brand = "Mitsubishi", Model = "Outlander 2", Year = 2014, EngineType = "4B11", MaxSpeed = 205, Type = "SUV"}
            };
        }
    }
}
