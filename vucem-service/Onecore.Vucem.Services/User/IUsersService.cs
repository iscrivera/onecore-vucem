// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUsersService.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Services.User
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Onecore.Vucem.Entities.Models;

    /// <summary>
    /// Interface User Service
    /// </summary>
    public interface IUsersService
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
