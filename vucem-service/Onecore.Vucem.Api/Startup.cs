// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Api
{
    using System;
    using Onecore.Vucem.Api.Filters;
    using Onecore.Vucem.DependencyInjection;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.OpenApi.Models;
    using Serilog;
    using Serilog.Events;
    using Steeltoe.Discovery.Client;

    /// <summary>
    /// Class Startup
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup" /> class.
        /// </summary>
        /// <param name="configuration">Service Configuration</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Gets Service Configuration
        /// </summary>
        public IConfiguration Configuration { get; private set; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">Service Collection</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);

            DependencyInjector.RegisterServices(services);
            DependencyInjector.AddAutoMapper();
            DependencyInjector.AddDbContext(this.Configuration);

            Log.Logger = new LoggerConfiguration().MinimumLevel.Information()
                .WriteTo.RollingFile("log-{Date}.txt", LogEventLevel.Information)
                /////.WriteTo.Seq("http://localhost:5341/") // Se puede user con la aplicacion alojada en la siguiente direccion https://getseq.net/
                .CreateLogger();

            ////Registra todos los eventos que suceden
            ILoggerFactory loggerFactory = new LoggerFactory();

            ////////loggerFactory.AddConsole(this.Configuration.GetSection("Logging"));
            ////////loggerFactory.AddDebug();
            loggerFactory.AddSerilog();
            services.AddSingleton(loggerFactory);

            services.AddDiscoveryClient(this.Configuration);

            /////Se adicionan a la configuracion de MVC los Filter, tambien registran en Log
            var mvcBuilder = services.AddMvc();
            mvcBuilder.AddMvcOptions(p => p.Filters.Add(new ActionFilter(Log.Logger)));
            mvcBuilder.AddMvcOptions(p => p.Filters.Add(new ExceptionFilter(Log.Logger)));

            ////////services.AddSwaggerGen(
            ////////    c =>
            ////////    {
            ////////        c.SwaggerDoc(
            ////////            "v1",
            ////////            new OpenApiInfo
            ////////            {
            ////////                Version = "v1",
            ////////                Title = "Api Microservice",
            ////////                Description = "Arquetipo de servicio Api NetCore",
            ////////                TermsOfService = new Uri("https://test.com"),
            ////////                Contact = new OpenApiContact
            ////////                {
            ////////                    Name = "Test",
            ////////                    Email = "test@axity.com",
            ////////                    Url = new Uri("https://test.com")
            ////////                }
            ////////            });
            ////////    });
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">Application Builder</param>
        /// <param name="env">Hosting Environment</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Microservice"));
            app.UseMvc();
            app.UseDiscoveryClient();
        }
    }
}
