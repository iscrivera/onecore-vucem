// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VucemController.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Onecore.Vucem.Facade.Operation;
    using Microsoft.AspNetCore.Mvc;
    using Dtos.Models;

    /// <summary>
    /// Class Users Controller
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VucemController : ControllerBase
    {
        /// <summary>
        /// Logic Facade
        /// </summary>
        private readonly IVucemOperationFacade logicFacade;

        /// <summary>
        /// Initializes a new instance of the <see cref="VucemController" /> class.
        /// </summary>
        /// <param name="logicFacade">Logic Facade</param>
        public VucemController(IVucemOperationFacade logicFacade)
        {
            this.logicFacade = logicFacade ?? throw new ArgumentNullException(nameof(logicFacade));
        }

        /// <summary>
        /// Get List of Users 
        /// </summary>
        /// <returns>List of Users</returns>
        [Route("/pedimentos")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            ////GET api/v1/[controller]/
            var response = await this.logicFacade.GetAllSO13012Async();
            return this.Ok(response);
        }

        /// <summary>
        /// Get List of Users 
        /// </summary>
        /// <returns>List of Users</returns>
        [Route("/pedimentos")]
        [HttpPatch]
        public async Task<IActionResult> Patch(UpdateNumOperationDto upd)
        {
            ////GET api/v1/[controller]/
            var response = await this.logicFacade.UpdateNumOperation(upd);
            return this.Ok(response);
        }
    }
}