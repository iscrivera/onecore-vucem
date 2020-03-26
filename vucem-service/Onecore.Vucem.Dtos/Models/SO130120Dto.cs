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
    public class SO130120Dto
    {
        /// <summary>
        /// Gets or sets Patente
        /// </summary>
        public string Patente { get; set; }

        /// <summary>
        /// Gets or sets id_Log
        /// </summary>
        public int id_Log { get; set; }

        /// <summary>
        /// Gets or sets Aduana
        /// </summary>
        public string Aduana { get; set; }

        /// <summary>
        /// Gets or sets Pedimento
        /// </summary>
        public string Pedimento { get; set; }

        /// <summary>
        /// Gets or sets RFC_Importador
        /// </summary>
        public string RFC_Importador { get; set; }

        /// <summary>
        /// Gets or sets RFC_Consulta
        /// </summary>
        public string RFC_Consulta { get; set; }

        /// <summary>
        /// Gets or sets NoOperacion
        /// </summary>
        public string NoOperacion { get; set; }

        /// <summary>
        /// Gets or sets Fecha_Pago
        /// </summary>
        public DateTime Fecha_Pago { get; set; }
    }
}
