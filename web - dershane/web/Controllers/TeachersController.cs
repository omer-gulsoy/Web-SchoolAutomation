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
			ViewBag.Lesson = Context.Lessons.ToList();
			var degerler = Context.Teachers.ToList();
			return View(degerler);
		}
		[HttpGet]
		public IActionResult Details(int id)
		{
			ViewBag.Comment = Context.Blogs.Where(x => x.Blog_Post_Id == id).ToList();
			ViewBag.Lesson = Context.Lessons.ToList();
			var e = Context.Teachers.Find(id);
			return View("Details", e);
		}
	}
}
