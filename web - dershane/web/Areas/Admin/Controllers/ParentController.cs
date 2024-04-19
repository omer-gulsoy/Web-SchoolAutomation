using data.Concrate;
using entity.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ParentController : Controller
	{
		Context Context = new Context();
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.Students=Context.Students.ToList();
			var degerler=Context.Parents.ToList();
			return View(degerler);
		}
		[HttpGet]
		public IActionResult ParentAdd()
		{
			ViewBag.Adresses=Context.Adresses.ToList();
			return View();
		}
		[HttpPost]
		public IActionResult ParentAdd(Parent p)
		{
			Context.Parents.Add(p);
			Context.SaveChanges();
			return RedirectToAction("Index","Parent");
		}
		public IActionResult ParentDelete(int id)
		{
			var silinecek = Context.Parents.Find(id);
			Context.Parents.Remove(silinecek);
			Context.SaveChanges();
			return RedirectToAction("Index", "Parent");
		}
		public IActionResult ParentGet(int id)
		{
			var getirilecek = Context.Parents.Find(id);
			return View("ParentGet", getirilecek);
		}
		public IActionResult ParentUpdate(Parent p)
		{
			var guncellenecek = Context.Parents.Find(p.Parent_Id);
			guncellenecek.Parent_Id = p.Parent_Id;
			guncellenecek.FirstName = p.FirstName;
			guncellenecek.LastName = p.LastName;
			guncellenecek.TC = p.TC;
			guncellenecek.BirtDay = p.BirtDay;
			guncellenecek.Phone = p.Phone;
			guncellenecek.Email = p.Email;
			guncellenecek.Hometown = p.Hometown;
			guncellenecek.Status = p.Status;
			guncellenecek.Adress_Id = p.Adress_Id;
			Context.SaveChanges();
			return RedirectToAction("Index", "Parent");
		}
	}
}
