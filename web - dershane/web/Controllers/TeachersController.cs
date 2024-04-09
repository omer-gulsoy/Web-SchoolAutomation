using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
	public class TeachersController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
