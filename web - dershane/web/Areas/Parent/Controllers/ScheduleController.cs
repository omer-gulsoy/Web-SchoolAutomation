using data.Concrate;
using entity.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Parent.Controllers
{
	[Area("Parent")]
	[Authorize(Roles = "PARENT")]
	public class ScheduleController : Controller
	{
		private readonly UserManager<AppUser> userManager;

		Context Context = new Context();
		[HttpGet]
		public IActionResult Index()
		{
			string TCS = TempData["TC"] as string;
			int TCI = 1;
			var parent = Context.Parents.FirstOrDefault(s => s.TC == TCI);
			var student = Context.Students.FirstOrDefault(s => s.Parent_Id == parent.Parent_Id);
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
