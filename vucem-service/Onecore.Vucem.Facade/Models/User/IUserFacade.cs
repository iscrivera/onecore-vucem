// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUserFacade.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Facade.Models.User
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Onecore.Vucem.Dtos.Models;

    /// <summary>
    /// Interface User Facade
    /// </summary>
    public interface IUserFacade
    {
        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>List of Users</returns>
        Task<IEnumerable<UserDto>> GetListUsersActive();

        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="id">User Id</param>
        /// <returns>User Object</returns>
        Task<UserDto> GetListUserActive(int id);

        /// <summary>
        /// Add new User
        /// </summary>
        /// <param name="user">User Object</param>
        /// <returns>True or False</returns>
        Task<bool> InsertUser(UserDto user);
    }
}
