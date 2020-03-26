// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUserFacade.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Facade.Operation
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Onecore.Vucem.Dtos.Models;

    /// <summary>
    /// Interface User Facade
    /// </summary>
    public interface IVucemOperationFacade
    {
        /// <summary>
        /// Get All Pedimentos
        /// </summary>
        /// <returns>List of Users</returns>
        Task<IEnumerable<SO130120Dto>> GetAllSO13012Async();

        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>List of Users</returns>
        Task<IEnumerable<SO130120Dto>> UpdateNumOperation(UpdateNumOperationDto upd);
    }
}
