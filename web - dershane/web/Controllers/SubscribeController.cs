using data.Concrate;
using entity.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
	public class SubscribeController : Controller
	{
		Context Context = new Context();
		[HttpPost]
		public IActionResult Index(Blog_Subscribe s)
		{
			Context.Blog_Subscribes.Add(s);
			Context.SaveChanges();
			return RedirectToAction("Index", "Blog");
		}
	}
}
