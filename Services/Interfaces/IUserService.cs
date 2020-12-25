using DataBase.Domain.UserRoleModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IUserService
    {
        bool IsAnExistingUser(string userName);
        bool IsValidUserCredentials(string userName, string password);
        string GetUserRole(string userName);
    }
}
