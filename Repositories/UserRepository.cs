using AutoMapper;
using DataBase.Context;
using DataBase.Domain.UserRoleModels;
using Microsoft.EntityFrameworkCore;
using Models.DTO;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private IMapper _mapper;
        private readonly CarsContext _context;
        public UserRepository(CarsContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public bool IsAnExistingUser(string userName)
        {
            return _context.Users.Any(x => x.Login == userName);
        }

        public bool IsValidUserCredentials(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            return _context.Users.Any(x => x.Login == userName && x.Password == password);
        }

        public string GetUserRole(string userName)
        {
            if (!IsAnExistingUser(userName))
            {
                return string.Empty;
            }

            var role = _context.UserRoles
                .Include(x => x.User)
                .Include(x => x.Role)
                .SingleOrDefault(x => x.User.Login == userName).Role?.Name;

            if (string.IsNullOrEmpty(role))
                throw new ArgumentNullException("Can't find role.");

            return role;
        }
    }
}
