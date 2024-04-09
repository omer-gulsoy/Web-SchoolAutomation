using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
