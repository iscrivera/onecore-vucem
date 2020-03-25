// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExceptionFilter.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Api.Filters
{
    using System.Net;
    using Onecore.Vucem.Resources.Exceptions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Serilog;

    /// <summary>
    /// Class ExceptionFilter
    /// </summary>
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        /// <summary>
        /// Logger object
        /// </summary>
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionFilter" /> class.
        /// </summary>
        /// <param name="logger">Logger object</param>
        public ExceptionFilter(ILogger logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// OnException Event
        /// </summary>
        /// <param name="context">Exception Context</param>
        public override void OnException(ExceptionContext context)
        {
            HttpStatusCode status = HttpStatusCode.InternalServerError;
            var message = string.Empty;

            var exceptionType = context.Exception.GetType();
            if (exceptionType == typeof(CustomServiceException))
            {
                message = "Error generico";
                status = HttpStatusCode.Conflict;
            }
            else
            {
                message = context.Exception.Message;
                status = HttpStatusCode.NotFound;
            }

            context.ExceptionHandled = true;

            var response = context.HttpContext.Response;
            response.StatusCode = (int)status;
            response.ContentType = "application/json";
            response.WriteAsync(message);

            var logMessage = $"ErrorType: {context.Exception.GetType()} Message: {context.Exception.Message}";
            this.logger.Error(logMessage);
        }
    }
}