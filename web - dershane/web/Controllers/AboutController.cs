using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
