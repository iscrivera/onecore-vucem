// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUsersDao.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.DataAccess.DAO.Operation
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Onecore.Vucem.Entities.Models;

    /// <summary>
    /// Interface IUserDao
    /// </summary>
    public interface ISO130120Dao
    {
        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>List of Users</returns>
        Task<IEnumerable<SO130120Model>> GetAllSO130120Async();

        /// <summary>
        /// Get All SO130120 by filter
        /// </summary>
        /// <returns>List of SO130120</returns>
        Task<IEnumerable<SO130120Model>> GetSO130120ByFilterAsync(string rfc, string fec_ini, string fec_fin);
    }
}
