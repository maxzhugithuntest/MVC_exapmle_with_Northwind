using Microsoft.AspNetCore.Mvc;
using MVC_exapmle_with_Northwind.Models;
using System.Diagnostics;

namespace MVC_exapmle_with_Northwind.Controllers
{
	public class HomeController : Controller
	{
		//private readonly ILogger<HomeController> _logger;

		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}

		// import DB
		private readonly NorthwindContext _context;

		public HomeController(NorthwindContext context)
		{
			_context = context;
		}

		// test connection
		//public string Index() {
		//		return _context.Products.FirstOrDefault().ProductName;
		//}

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
