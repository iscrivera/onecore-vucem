// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsersController.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Onecore.Vucem.Dtos.Models;
    using Onecore.Vucem.Facade.Models.User;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Class Users Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Logic Facade
        /// </summary>
        private readonly IUserFacade logicFacade;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController" /> class.
        /// </summary>
        /// <param name="logicFacade">Logic Facade</param>
        public UsersController(IUserFacade logicFacade)
        {
            this.logicFacade = logicFacade ?? throw new ArgumentNullException(nameof(logicFacade));
        }

        /// <summary>
        /// Get List of Users 
        /// </summary>
        /// <returns>List of Users</returns>
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            ////GET api/v1/[controller]/
            var response = await this.logicFacade.GetListUsersActive();
            return this.Ok(response);
        }

        /// <summary>
        /// Get User By ID 
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <returns>User Object</returns>
        [Route("{userId}")]
        [HttpGet]
        public async Task<IActionResult> Get(int userId)
        {
            ////GET api/v1/[controller]/user/1
            var response = await this.logicFacade.GetListUserActive(userId);
            return this.Ok(response);
        }

        /// <summary>
        /// Add New User
        /// </summary>
        /// <param name="user">User Object</param>
        /// <returns>True or False</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDto user)
        {
            var response = await this.logicFacade.InsertUser(user);
            return this.Ok(response);
        }

        /// <summary>
        /// Ping 
        /// </summary>
        /// <returns>Pong</returns>
        [Route("/ping")]
        [HttpGet]
        public async Task<IActionResult> Ping()
        {
            return this.Ok("Pong");
        }
    }
}