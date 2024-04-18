using data.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
	public class TeachersController : Controller
	{
		Context Context = new Context();
		[HttpGet]
		public IActionResult Index()
		{
			var degerler = Context.Teachers.ToList();
			return View(degerler);
		}
		[HttpGet]
		public IActionResult Details()
		{
			return View();
		}
	}
}
