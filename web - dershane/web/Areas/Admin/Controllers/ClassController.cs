using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ClassController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
