// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SO130120Dao.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.DataAccess.DAO.Operation
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Onecore.Vucem.Entities.Context;
    using Onecore.Vucem.Entities.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    /// <summary>
    /// Class for SO130120 Dao
    /// </summary>
    public class SO130120Dao : ISO130120Dao
    {
        /// <summary>
        /// Data Base Context
        /// </summary>
        private readonly IDatabaseContext databaseContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="SO130120Dao" /> class.
        /// </summary>
        /// <param name="databaseContext">Data Base Context</param>
        public SO130120Dao(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext));
        }

        /// <summary>
        /// Get All SO130120
        /// </summary>
        /// <returns>List of SO130120</returns>
        public async Task<IEnumerable<SO130120Model>> GetAllSO130120Async()
        {
            return await this.databaseContext.CatSO130120.AsQueryable().Take(5).ToListAsync();
        }

        /// <summary>
        /// Get All SO130120 by filter
        /// </summary>
        /// <returns>List of SO130120</returns>
        public async Task<IEnumerable<SO130120Model>> GetSO130120ByFilterAsync(string rfc, string fec_ini, string fec_fin)
        {
            DateTime? dateFrom = DateTime.ParseExact(fec_ini, "yyyy-MM-dd", null);
            DateTime? dateTo = DateTime.ParseExact(fec_fin, "yyyy-MM-dd", null);

            return await this.databaseContext.CatSO130120.AsQueryable().Where(p => rfc.ToUpper().Equals(p.RFC_Consulta.ToUpper())
            && (p.Fecha_Pago >= dateFrom.Value && p.Fecha_Pago <= dateTo.Value)).ToListAsync();
        }
    }
}
