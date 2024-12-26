using Microsoft.AspNetCore.Mvc;
using MVC_exapmle_with_Northwind.Models;
using System.Diagnostics;

namespace MVC_exapmle_with_Northwind.Controllers
{
	public class HomeController : Controller
	{		

		// import DB
		private readonly NorthwindContext _context;

		public HomeController(NorthwindContext context)
		{
			_context = context;
		}		

		public IActionResult Index()
		{
			return View();
		}


		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
