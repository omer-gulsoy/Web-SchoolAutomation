using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
