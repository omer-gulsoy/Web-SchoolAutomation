using data.Concrate;
using entity.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TeacherController : Controller
	{
		Context Context = new Context();
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.Lesson = Context.Lessons.ToList();
			var teachers = Context.Teachers.ToList();
			return View(teachers);
		}
		[HttpGet]
		public IActionResult TeacherAdd()
		{
			ViewBag.Lessons = Context.Lessons.ToList();
			return View();
		}
		[HttpPost]
		public IActionResult TeacherAdd(Teacher t)
		{
			Context.Teachers.Add(t);
			Context.SaveChanges();
			return RedirectToAction("Index", "Teacher");
		}
		public IActionResult TeacherDelete(int id)
		{
			var silinecek = Context.Teachers.Find(id);
			Context.Teachers.Remove(silinecek);
			Context.SaveChanges();
			return RedirectToAction("Index", "Teacher");
		}
		public IActionResult TeacherGet(int id)
		{
			var getirilecek = Context.Teachers.Find(id);
			return View("TeacherGet", getirilecek);
		}
		public IActionResult TeacherUpdate(Teacher t)
		{
			var guncellenecek = Context.Teachers.Find(t.Teacher_Id);
			guncellenecek.Teacher_Id = t.Teacher_Id;
			guncellenecek.FirstName = t.FirstName;
			guncellenecek.LastName = t.LastName;
			guncellenecek.TC = t.TC;
			guncellenecek.BirthDay = t.BirthDay;
			guncellenecek.Phone = t.Phone;
			guncellenecek.Email = t.Email;
			guncellenecek.Hometown = t.Hometown;
			guncellenecek.PrePhotoURL = t.PrePhotoURL;
			guncellenecek.DetailPhotoURL = t.DetailPhotoURL;
			guncellenecek.PreBio = t.PreBio;
			guncellenecek.DetailBio = t.DetailBio;
			guncellenecek.Status = t.Status;
			guncellenecek.Lesson_Id = t.Lesson_Id;
			Context.SaveChanges();
			return RedirectToAction("Index", "Teacher");
		}
	}
}
