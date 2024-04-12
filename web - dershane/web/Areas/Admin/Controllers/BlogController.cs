using data.Concrate;
using entity.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
	[Area("Admin")]
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
		public IActionResult PostAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult PostAdd(Blog_Post p)
		{
			Context.Blog_Posts.Add(p);
			Context.SaveChanges();
			return RedirectToAction("Index", "Blog");
			return View();
		}
		public IActionResult PostDelete(int id)
		{
			var w = Context.Blog_Posts.Find(id);
			Context.Blog_Posts.Remove(w);
			Context.SaveChanges();
			return RedirectToAction("Index", "Blog");
		}
		public IActionResult PostGet(int id)
		{
			var e = Context.Blog_Posts.Find(id);
			return View("PostGet", e);
		}
		public IActionResult PostUpdate(Blog_Post s)
		{
			var r = Context.Blog_Posts.Find(s.Blog_Post_Id);
			r.Blog_Post_Id = s.Blog_Post_Id;
			r.Title = s.Title;
			r.Summary = s.Summary;
			r.Article = s.Article;
			r.PhotoURL = s.PhotoURL;
			r.Status = s.Status;
			Context.SaveChanges();
			return RedirectToAction("Index", "Blog");
		}
	}
}
