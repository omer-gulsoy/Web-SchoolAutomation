using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
	public class TeachersController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
        [HttpGet]
        public IActionResult Details() 
		{
			return View();
		}
    }
}
