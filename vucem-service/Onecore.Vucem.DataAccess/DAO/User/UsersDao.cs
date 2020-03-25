// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsersDao.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.DataAccess.DAO.User
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Onecore.Vucem.Entities.Context;
    using Onecore.Vucem.Entities.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Class for User Dao
    /// </summary>
    public class UsersDao : IUsersDao
    {
        /// <summary>
        /// Data Base Context
        /// </summary>
        private readonly IDatabaseContext databaseContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersDao" /> class.
        /// </summary>
        /// <param name="databaseContext">Data Base Context</param>
        public UsersDao(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext));
        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>List of Users</returns>
        public async Task<IEnumerable<UserModel>> GetAllUsersAsync()
        {
            return await this.databaseContext.CatUser.ToListAsync();
        }

        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <returns>User Object</returns>
        public async Task<UserModel> GetUserAsync(int userId)
        {
            return await this.databaseContext.CatUser.FirstOrDefaultAsync(p => p.Id.Equals(userId));
        }

        /// <summary>
        /// Add new User
        /// </summary>
        /// <param name="user">User objet to add</param>
        /// <returns>True or false</returns>
        public async Task<bool> InsertUser(UserModel user)
        {
            var response = await this.databaseContext.CatUser.AddAsync(user);
            return response.State.Equals(EntityState.Added);
        }
    }
}
