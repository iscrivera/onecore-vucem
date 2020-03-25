// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionFilter.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Api.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.AspNetCore.Routing;
    using Serilog;

    /// <summary>
    /// Class Action Filter
    /// </summary>
    public class ActionFilter : ActionFilterAttribute
    {
        /// <summary>
        /// Logger object
        /// </summary>
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionFilter" /> class.
        /// </summary>
        /// <param name="logger">Logger Object</param>
        public ActionFilter(ILogger logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// OnActionExecuting Event
        /// </summary>
        /// <param name="filterContext">Filter Context</param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this.Log("OnActionExecuting", filterContext.RouteData);
        }

        /// <summary>
        /// OnActionExecuted Event
        /// </summary>
        /// <param name="filterContext">Filter Context</param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            this.Log("OnActionExecuted", filterContext.RouteData);
        }

        /// <summary>
        /// OnResultExecuting Event
        /// </summary>
        /// <param name="filterContext">Filter Context</param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            this.Log("OnResultExecuting", filterContext.RouteData);
        }

        /// <summary>
        /// OnResultExecuted Event
        /// </summary>
        /// <param name="filterContext">Filter Context</param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            this.Log("OnResultExecuted", filterContext.RouteData);
        }

        /// <summary>
        /// Log actions
        /// </summary>
        /// <param name="methodName">Method Name</param>
        /// <param name="routeData">Route Data</param>
        private void Log(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];

            var message = string.Format("{0} Controller: {1} Action:{2}", methodName, controllerName, actionName);
            this.logger.Information(message);
        }
    }
}