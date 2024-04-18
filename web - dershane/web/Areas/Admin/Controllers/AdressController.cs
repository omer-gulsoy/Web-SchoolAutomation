using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AdressController : Controller
	{
		public IActionResult Index()
		{
			string Title = "Adres";
			ViewBag.Title = Title;
			return View();
		}
	}
}
