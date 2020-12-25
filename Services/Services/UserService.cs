using AutoMapper;
using Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class UserService : IUserService
    {
        public readonly IMapper _mapper;
        protected readonly UnitOfWork _unit;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapper">Mapper</param>
        /// <param name="unit">UnitOfWork</param>
        public UserService(IMapper mapper, UnitOfWork unit)
        {
            _mapper = mapper;
            _unit = unit;
        }
        public string GetUserRole(string userName)
        {
            return _unit.userRepository.GetUserRole(userName);
        }

        public bool IsAnExistingUser(string userName)
        {
            return _unit.userRepository.IsAnExistingUser(userName);
        }

        public bool IsValidUserCredentials(string userName, string password)
        {
            return _unit.userRepository.IsValidUserCredentials(userName, password);
        }
    }
}
