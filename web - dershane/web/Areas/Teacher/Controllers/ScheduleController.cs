using data.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Teacher.Controllers
{
	[Area("Teacher")]
	[Authorize(Roles = "TEACHER")]
	public class ScheduleController : Controller
	{
		Context Context = new Context();
		[HttpGet]
		public IActionResult Index()
		{
			string TCS = TempData["teacherTC"] as string;
			int TCI = int.Parse(TCS);
			ViewBag.hoca = Context.Teachers.Where(t => t.Teacher_Id == TCI);


			var program = Context.Schedules.Where(p => p.Teacher_Id == TCI);

			DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
			DateTime endOfWeek = startOfWeek.AddDays(6);

			var degerler = program.Where(x => x.Time >= startOfWeek && x.Time <= endOfWeek).ToList();


			return View(degerler);
		}
	}
}
