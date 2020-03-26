// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SO130120Model.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Entities.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Class SO130120Model
    /// </summary>
    [Table("SO130120")]
    public class SO130120Model
    {
        [Key]
        public int id_Log { get; set; }

        /// <summary>
        /// Gets or sets Patente
        /// </summary>
        public string Patente { get; set; }

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
