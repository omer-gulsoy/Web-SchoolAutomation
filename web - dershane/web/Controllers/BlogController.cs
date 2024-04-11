using data.Concrate;
using entity.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
	public class BlogController : Controller
	{
		Context Context = new Context();
		[HttpGet]
		public IActionResult Index()
		{
			var degerler = Context.Blog_Posts.ToList();
			return View(degerler);
		}
		[HttpGet]
		public IActionResult Details(int id)
		{
			ViewBag.Posts = Context.Blog_Posts.ToList();
			ViewBag.Comment = Context.Blog_Comments.Where(x => x.Blog_Post_Id == id).ToList();
			var e = Context.Blog_Posts.Find(id);
			return View("Details", e);
		}
		[HttpPost]
		public IActionResult Details(Blog_Comment c)
		{
			Context.Blog_Comments.Add(c);
			Context.SaveChanges();
			return View();
		}
	}
}
