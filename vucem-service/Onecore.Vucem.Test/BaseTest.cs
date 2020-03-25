// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseTest.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Test
{
    using System.Collections.Generic;
    using AutoMapper;
    using Onecore.Vucem.DataAccess.DAO.User;
    using Onecore.Vucem.Entities.Context;
    using Onecore.Vucem.Entities.Models;

    /// <summary>
    /// Abstract Class Base Test
    /// </summary>
    public abstract class BaseTest
    {
        /// <summary>
        /// Object Mapper
        /// </summary>
        public IMapper Mapper;

        /// <summary>
        /// Object usersDao
        /// </summary>
        public IUsersDao UsersDao;

        /// <summary>
        /// Object Context
        /// </summary>
        public DatabaseContext Context;

        /// <summary>
        /// Method Get All Users
        /// </summary>
        /// <returns>List of Users</returns>
        public IEnumerable<UserModel> GetAllUsers()
        {
            return new List<UserModel>()
            {
                new UserModel { Id = 1, FirstName = "Alejandro", LastName = "Ojeda", Email = "alejandro.ojeda@axity.com" },
                new UserModel { Id = 2, FirstName = "Jorge", LastName = "Morales", Email = "jorge.morales@axity.com" },
                new UserModel { Id = 3, FirstName = "Arturo", LastName = "Miranda", Email = "arturo.miranda@axity.com" },
                new UserModel { Id = 4, FirstName = "Benjamin", LastName = "Galindo", Email = "benjamin.galindo@axity.com" }
            };
        }
    }
}
