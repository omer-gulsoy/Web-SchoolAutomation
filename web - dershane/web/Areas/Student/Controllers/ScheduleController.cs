using data.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace web.Areas.Student.Controllers
{
	[Area("Student")]
	[Authorize(Roles = "STUDENT")]
	public class ScheduleController : Controller
	{
		Context Context = new Context();
		[HttpGet]
		public IActionResult Index()
		{
			string TCS = TempData["TC"] as string;
			int TCI = int.Parse(TCS);
			var student = Context.Students.FirstOrDefault(s => s.TC == TCI);
			int sinifId = student.Class_Id;
			ViewBag.ogrSinif = Context.Classes.Where(s => s.Class_Id == sinifId);
			ViewBag.Teacher = Context.Teachers.ToList();
			ViewBag.Lesson = Context.Lessons.ToList();

			var program = Context.Schedules.Where(p => p.Class_Id == sinifId);

			DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
			DateTime endOfWeek = startOfWeek.AddDays(6);

			var degerler = program.Where(x => x.Time >= startOfWeek && x.Time <= endOfWeek).ToList();


			return View(degerler);
		}
	}
}
