// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDto.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Dtos.Models
{
    using System;

    /// <summary>
    /// Class for User
    /// </summary>
    public class UserDto
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
        /// Gets or sets Birth Date
        /// </summary>
        public DateTime Birthdate { get; set; }
    }
}
