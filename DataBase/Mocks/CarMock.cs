using DataBase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Mocks
{
    /// <summary>
    /// Mock объект для модели car
    /// Обладает методами для поиска авто по id,удаление из объекта и выдачу всего списка
    /// </summary>
    public static class CarMock
    {
        public static List<Car> Cars = new List<Car>() {
                new Car { Id=1, Brand = "KIA Motors", Model = "Rio",Year = 2020, EngineType = "Rio 1.6", MaxSpeed = 198, Type = "Sedan", Price = 700},
                new Car { Id=2, Brand = "Audi", Model = "A6", Year = 2018, EngineType = "V6", MaxSpeed = 250, Type = "Sedan", Price = 1500},
                new Car { Id=3, Brand = "Mitsubishi", Model = "Outlander 2", Year = 2014, EngineType = "4B11", MaxSpeed = 205, Type = "SUV", Price = 900}
             };
        public static IEnumerable<Car> GetCars()
        {
            return Cars;
        }
        public static void DeleteCarById(int id)
        {
            Cars.Remove(Cars.Find(x => x.Id == id));
        }
        public static bool FindCarById(int id)
        {
            var car = Cars.Find(x => x.Id == id);
            if(car!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
