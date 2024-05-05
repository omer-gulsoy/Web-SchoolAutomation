using data.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Parent.Controllers
{
	[Area("Parent")]
	[Authorize(Roles = "PARENT")]
	public class StudentController : Controller
	{
		Context Context = new Context();
		[HttpGet]
		public IActionResult Index()
		{
			string TCS = TempData["parentTC"] as string;
			int TCI = int.Parse(TCS);
			var student = Context.Students.FirstOrDefault(s => s.Parent_Id == TCI);
			return View(student);
		}
	}
}
