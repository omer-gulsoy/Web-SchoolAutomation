using data.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TeacherController : Controller
	{
		Context Context=new Context();
		public IActionResult Index()
		{
			return View();
		}
	}
}
