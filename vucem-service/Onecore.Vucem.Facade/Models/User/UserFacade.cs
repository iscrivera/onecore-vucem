// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserFacade.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Facade.Models.User
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using Onecore.Vucem.Dtos.Models;
    using Onecore.Vucem.Entities.Models;
    using Onecore.Vucem.Services.User;

    /// <summary>
    /// Class User Facade
    /// </summary>
    public class UserFacade : IUserFacade
    {
        /// <summary>
        /// User Service
        /// </summary>
        private readonly IUsersService usersService;

        /// <summary>
        /// Mapper Object
        /// </summary>
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFacade" /> class.
        /// </summary>
        /// <param name="mapper">Object Mapper</param>
        /// <param name="usersService">User Service</param>
        public UserFacade(IMapper mapper, IUsersService usersService)
        {
            this.mapper = mapper;
            this.usersService = usersService ?? throw new ArgumentNullException(nameof(usersService));
        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>List of Users</returns>
        public async Task<IEnumerable<UserDto>> GetListUsersActive()
        {
            return this.mapper.Map<List<UserDto>>(await this.usersService.GetAllUsersAsync());
        }

        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="id">User Id</param>
        /// <returns>User Object</returns>
        public async Task<UserDto> GetListUserActive(int id)
        {
            return this.mapper.Map<UserDto>(await this.usersService.GetUserAsync(id));
        }

        /// <summary>
        /// Add new User
        /// </summary>
        /// <param name="user">User objet to add</param>
        /// <returns>True or false</returns>
        public async Task<bool> InsertUser(UserDto user)
        {
            return await this.usersService.InsertUser(this.mapper.Map<UserModel>(user));
        }
    }
}
