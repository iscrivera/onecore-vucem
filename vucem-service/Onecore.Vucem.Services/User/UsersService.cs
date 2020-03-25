// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsersService.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Services.User
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Onecore.Vucem.DataAccess.DAO.User;
    using Onecore.Vucem.Entities.Models;

    /// <summary>
    /// Class UsersService
    /// </summary>
    public class UsersService : IUsersService
    {
        /// <summary>
        /// User Dao Interface
        /// </summary>
        private readonly IUsersDao userDao;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersService" /> class.
        /// </summary>
        /// <param name="userDao">User dao</param>
        public UsersService(IUsersDao userDao)
        {
            this.userDao = userDao ?? throw new ArgumentNullException(nameof(userDao));
        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>List of Users</returns>
        public async Task<IEnumerable<UserModel>> GetAllUsersAsync()
        {
            return await this.userDao.GetAllUsersAsync();
        }

        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <returns>User Object</returns>
        public async Task<UserModel> GetUserAsync(int userId)
        {
            return await this.userDao.GetUserAsync(userId);
        }

        /// <summary>
        /// Add new User
        /// </summary>
        /// <param name="user">User objet to add</param>
        /// <returns>True or false</returns>
        public async Task<bool> InsertUser(UserModel user)
        {
            return await this.userDao.InsertUser(user);
        }
    }
}
