using data.Concrate;
using entity.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ScheduleController : Controller
	{
		Context Context = new Context();
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult ScheduleAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult ScheduleAdd(Schedule s)
		{
			Context.Schedules.Add(s);
			Context.SaveChanges();
			return RedirectToAction("Index", "Schedule");
		}
		public IActionResult ScheduleDelete(int id)
		{
			var silinecek = Context.Schedules.Find(id);
			Context.Schedules.Remove(silinecek);
			Context.SaveChanges();
			return RedirectToAction("Index", "Schedule");
		}
		public IActionResult ScheduleGet(int id)
		{
			var getirilecek = Context.Schedules.Find(id);
			return View("Schedule", getirilecek);
		}
		public IActionResult ScheduleUpdate(Schedule s)
		{
			var guncellenecek = Context.Schedules.Find(s.Schedule_Id);
			guncellenecek.Schedule_Id = s.Schedule_Id;
			guncellenecek.Time = s.Time;
			guncellenecek.Teacher_Id = s.Teacher_Id;
			guncellenecek.Class_Id = s.Class_Id;
			guncellenecek.Status = s.Status;
			Context.SaveChanges();
			return RedirectToAction("Index", "Schedule");
		}
	}
}
