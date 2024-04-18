using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ScheduleController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
