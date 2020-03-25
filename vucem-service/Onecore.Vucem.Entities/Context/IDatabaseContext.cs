// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDatabaseContext.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Entities.Context
{
    using Onecore.Vucem.Entities.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Interface IDataBaseContext
    /// </summary>
    public interface IDatabaseContext
    {
        /// <summary>
        /// Gets or sets CatUser
        /// </summary>
        DbSet<UserModel> CatUser { get; set; }
    }
}
