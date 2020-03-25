// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUsersDao.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.DataAccess.DAO.User
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Onecore.Vucem.Entities.Models;

    /// <summary>
    /// Interface IUserDao
    /// </summary>
    public interface IUsersDao
    {
        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>List of Users</returns>
        Task<IEnumerable<UserModel>> GetAllUsersAsync();

        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <returns>User Object</returns>
        Task<UserModel> GetUserAsync(int userId);

        /// <summary>
        /// Add new User
        /// </summary>
        /// <param name="user">User objet to add</param>
        /// <returns>True or false</returns>
        Task<bool> InsertUser(UserModel user);
    }
}
