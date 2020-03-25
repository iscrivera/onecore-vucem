// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Api
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Steeltoe.Extensions.Configuration.CloudFoundry;
    using Steeltoe.Extensions.Configuration.PlaceholderCore;

    /// <summary>
    /// Class Program
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Method Main
        /// </summary>
        /// <param name="args">Array of arguments</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Method to create Web Host Builder
        /// </summary>
        /// <param name="args">Array of arguments</param>
        /// <returns>Object Web Host Builder</returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseCloudFoundryHosting(5050)
                .AddCloudFoundry()
                .AddPlaceholderResolver()
                .UseStartup<Startup>();
    }
}
