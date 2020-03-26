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
    public class UpdateNumOperationDto
    {
        /// <summary>
        /// Gets or sets RFC_Consulta
        /// </summary>
        public string RFC_Consulta { get; set; }

        /// <summary>
        /// Gets or sets Fecha_Pago_Ini
        /// </summary>
        public string Fecha_Pago_Ini { get; set; }

        /// <summary>
        /// Gets or sets Fecha_Pago_Fin
        /// </summary>
        public string Fecha_Pago_Fin { get; set; }
    }
}
