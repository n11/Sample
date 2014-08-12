using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Extensions;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		[LoggingError()]
		[Logging()]
		public ActionResult Index()
		{
			//throw new Exception("hogehoge");

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}