// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserModel.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Entities.Models
{
    using System;

    /// <summary>
    /// Class UserModel
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Gets or sets User Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets Email Address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Birthdate
        /// </summary>
        public DateTime Birthdate { get; set; }
    }
}
