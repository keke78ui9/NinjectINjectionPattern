using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjectINjectionPattern;

namespace NinjectINjectionPattern.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{
			ITest test = new Test2();

			ViewBag.Message = string.Format("Id is {0}, Name is {1}, GetValue() is {2}",
				test.Id, test.Name, test.GetValue());
			return View();
		}
	}
}
