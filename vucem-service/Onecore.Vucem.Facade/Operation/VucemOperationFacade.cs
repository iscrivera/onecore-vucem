// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserFacade.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Facade.Operation
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using Onecore.Vucem.Dtos.Models;
    using Onecore.Vucem.Services.Operation;

    /// <summary>
    /// Class User Facade
    /// </summary>
    public class VucemOperationFacade : IVucemOperationFacade
    {
        /// <summary>
        /// User Service
        /// </summary>
        private readonly IVucemSO130120Service sO130120Service;

        /// <summary>
        /// Mapper Object
        /// </summary>
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="VucemOperationFacade" /> class.
        /// </summary>
        /// <param name="mapper">Object Mapper</param>
        /// <param name="usersService">User Service</param>
        public VucemOperationFacade(IMapper mapper, IVucemSO130120Service sO130120Service)
        {
            this.mapper = mapper;
            this.sO130120Service = sO130120Service ?? throw new ArgumentNullException(nameof(sO130120Service));
        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>List of Users</returns>
        public async Task<IEnumerable<SO130120Dto>> GetAllSO13012Async()
        {
            return this.mapper.Map<List<SO130120Dto>>(await this.sO130120Service.GetAllSO130120Async());
        }

        /// <summary>
        /// Update number operation
        /// </summary>
        /// <returns>List of Users</returns>
        public async Task<IEnumerable<SO130120Dto>> UpdateNumOperation(UpdateNumOperationDto upd)
        {
            return this.mapper.Map<List<SO130120Dto>>(await this.sO130120Service.GetSO130120ByFilterAsync(upd.RFC_Consulta, upd.Fecha_Pago_Ini, upd.Fecha_Pago_Fin));
        }
    }
}
