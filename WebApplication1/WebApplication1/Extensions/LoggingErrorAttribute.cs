using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Extensions
{
	public class LoggingErrorAttribute : FilterAttribute, IExceptionFilter
	{
		public void OnException(ExceptionContext filterContext)
		{
			if (filterContext == null)
			{
				throw new ArgumentException("filterContext");
			}

			var route = filterContext.RouteData;
			var exp = filterContext.Exception;

			var err = string.Format("{0}, {1}, {2}, {3}, {4}", route.Values["controller"].ToString(),
																route.Values["action"].ToString(),
																exp.Message,
																exp.StackTrace,
																DateTime.Now);
		}
	}
}