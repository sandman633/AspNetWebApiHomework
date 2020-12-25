using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    interface IUserRepository 
    {
        /// <summary>
        /// Check user
        /// </summary>
        bool IsAnExistingUser(string userName);

        /// <summary>
        /// Validate user data
        /// </summary>
        bool IsValidUserCredentials(string userName, string password);

        /// <summary>
        /// Get user role if exists
        /// </summary>
        string GetUserRole(string userName);
    }
}
