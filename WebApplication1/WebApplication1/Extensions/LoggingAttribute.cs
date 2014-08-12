using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Extensions
{
	public class LoggingAttribute : ActionFilterAttribute
	{
		public override void OnResultExecuted(ResultExecutedContext filterContext)
		{
			if (filterContext == null)
			{
				throw new ArgumentException("filterContext");
			}

			var req = filterContext.HttpContext.Request;
			var log = string.Format("{0}, {1}, {2}", req.Url.AbsoluteUri, req.UserAgent, DateTime.Now);
		}
	}
}