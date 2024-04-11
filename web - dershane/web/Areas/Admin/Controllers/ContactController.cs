using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ContactController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
	}
}
