// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VucemOperationService.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Services.Operation
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Onecore.Vucem.DataAccess.DAO.Operation;
    using Onecore.Vucem.Entities.Models;

    /// <summary>
    /// Class VucemOperationService
    /// </summary>
    public class VucemSO130120Service : IVucemSO130120Service
    {
        /// <summary>
        /// User Dao Interface
        /// </summary>
        private readonly ISO130120Dao sO130120Dao;

        /// <summary>
        /// Initializes a new instance of the <see cref="VucemOperationService" /> class.
        /// </summary>
        /// <param name="sO130120Dao">sO130120 dao</param>
        public VucemSO130120Service(ISO130120Dao sO130120Dao)
        {
            this.sO130120Dao = sO130120Dao ?? throw new ArgumentNullException(nameof(sO130120Dao));
        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>List of Users</returns>
        public async Task<IEnumerable<SO130120Model>> GetAllSO130120Async()
        {
            return await this.sO130120Dao.GetAllSO130120Async();
        }

        /// <summary>
        /// Get All SO130120 by filter
        /// </summary>
        /// <returns>List of SO130120</returns>
        public async Task<IEnumerable<SO130120Model>> GetSO130120ByFilterAsync(string rfc, string fec_ini, string fec_fin)
        {
            return await this.sO130120Dao.GetSO130120ByFilterAsync(rfc, fec_ini, fec_fin);
        }
    }
}
