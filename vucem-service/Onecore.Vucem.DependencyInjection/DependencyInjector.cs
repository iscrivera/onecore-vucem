// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DependencyInjector.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.DependencyInjection
{
    using AutoMapper;
    using Onecore.Vucem.Entities.Context;
    using Onecore.Vucem.Facade.Mapping;
    using Onecore.Vucem.Facade.Operation;
    using Onecore.Vucem.Services.Operation;
    using Onecore.Vucem.DataAccess.DAO.Operation;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Class DependencyInjector
    /// </summary>
    public class DependencyInjector
    {
        /// <summary>
        /// Gets or sets Services
        /// </summary>
        private static IServiceCollection Services { get; set; }

        /// <summary>
        /// Register Services
        /// </summary>
        /// <param name="services">Services Collection</param>
        /// <returns>Services Object</returns>
        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            Services = services;

            Services.AddTransient<IVucemOperationFacade, VucemOperationFacade>();

            Services.AddTransient<IVucemSO130120Service, VucemSO130120Service>();

            Services.AddTransient<ISO130120Dao, SO130120Dao>();

            Services.AddTransient<IDatabaseContext, DatabaseContext>();

            return Services;
        }

        /// <summary>
        /// Add DBContext
        /// </summary>
        /// <param name="configuration">Configuration Context</param>
        public static void AddDbContext(IConfiguration configuration)
        {
            Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString(nameof(DatabaseContext))));
        }

        /// <summary>
        /// Add Auto Mapper Configuration
        /// </summary>
        public static void AddAutoMapper()
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new AutoMapperProfile()); });
            Services.AddSingleton(mappingConfig.CreateMapper());
        }
    }
}
