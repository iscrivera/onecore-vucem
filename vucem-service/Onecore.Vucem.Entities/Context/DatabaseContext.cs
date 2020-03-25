// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DatabaseContext.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Entities.Context
{
    using Onecore.Vucem.Entities.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Database context
    /// </summary>
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseContext" /> class.
        /// </summary>
        /// <param name="options">Object DataBaseContextOptions</param>
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets CatUser
        /// </summary>
        public virtual DbSet<UserModel> CatUser { get; set; }
    }
}
