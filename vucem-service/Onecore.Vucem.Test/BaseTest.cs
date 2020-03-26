// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseTest.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Test
{
    using System.Collections.Generic;
    using AutoMapper;
    using Onecore.Vucem.DataAccess.DAO.Operation;
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
        public ISO130120Dao UsersDao;

        /// <summary>
        /// Object Context
        /// </summary>
        public DatabaseContext Context;

        /// <summary>
        /// Method Get All Users
        /// </summary>
        /// <returns>List of Users</returns>
        public IEnumerable<SO130120Model> GetAllUsers()
        {
            return new List<SO130120Model>()
            {
                new SO130120Model {
                    Aduana = "321"
                }
            };
        }
    }
}
