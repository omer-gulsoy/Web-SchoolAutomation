using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult Workplace()
		{
			return View();
		}
		[HttpGet]
		public IActionResult System()
		{
			return View();
		}
    }
}
