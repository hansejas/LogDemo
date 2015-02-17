using LogDemoWeb.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogDemoWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [LogFilter]
        public ActionResult Index()
        {
            return View();
        }
	}
}