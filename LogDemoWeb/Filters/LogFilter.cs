using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Acurenz.Logging;

namespace LogDemoWeb.Filters
{
    public class LogFilter : ActionFilterAttribute, IActionFilter
    {

        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            ILogger logger = new NLogLogger(); // TODO: DI this.
            logger.InformationEnabled = true; // tODO: get this from web.config
            logger.Information(String.Format("Controller {0} with Action {1} called at {2}", filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, filterContext.ActionDescriptor.ActionName, filterContext.HttpContext.Timestamp.ToShortDateString()));
            this.OnActionExecuting(filterContext);
        }
    }
}