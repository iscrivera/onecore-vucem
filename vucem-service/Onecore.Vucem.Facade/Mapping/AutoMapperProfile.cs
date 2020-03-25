// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoMapperProfile.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Facade.Mapping
{
    using AutoMapper;
    using Onecore.Vucem.Dtos.Models;
    using Onecore.Vucem.Entities.Models;

    /// <summary>
    /// Class AutoMapperProfile
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoMapperProfile" /> class.
        /// </summary>
        public AutoMapperProfile()
        {
            this.CreateMap<UserModel, UserDto>();
            this.CreateMap<UserDto, UserModel>();
        }
    }
}
