using FoodyTekmerDataAccessLayer.AppDbContext;
using FoodyTekmerEntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.Controllers
{
    public class CategoryController : Controller
    {

        FoodyContext context= new FoodyContext();
        public IActionResult Index()
        {
            var values= context.Categories.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCategory() 
        {
            return View();
        
        }

        [HttpPost]

        public IActionResult CreateCategory(Category p)
        {
            context.Categories.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var values = context.Categories.Find(id);
            context.Categories.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values =context.Categories.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category p)
        {
            context.Categories.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
