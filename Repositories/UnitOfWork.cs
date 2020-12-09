using AutoMapper;
using DataBase.Context;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    /// <summary>
    /// UnitOfWork
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        /// <summary>
        /// Добавляем нужные поля
        /// Контекст
        /// И два репозитория
        /// </summary>
        private CarsContext _context;
        private IMapper _mapper;
        private CarRepository _carRepository;
        private EngineRepository _engineRepository;
        private bool disposed = false;
        public CarRepository carsRepository
        {
            get
            {
                if (_carRepository == null)
                    _carRepository = new CarRepository(_context, _mapper);
                return _carRepository;
            }
        }
        public EngineRepository engineRepository
        {
            get
            {
                if (_engineRepository == null)
                    _engineRepository = new EngineRepository(_context, _mapper);
                return _engineRepository;
            }
        }

        public UnitOfWork(IMapper mapper, CarsContext context)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        
        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
