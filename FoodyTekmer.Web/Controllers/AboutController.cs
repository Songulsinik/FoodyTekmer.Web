using FoodyTekmerBusinessLayer.Abstract;
using FoodyTekmerDataAccessLayer.AppDbContext;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.Controllers
{
    public class AboutController : Controller
    {
        FoodyContext context=new FoodyContext();

        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values=_aboutService.TGetAllList();
            return View(values);
        }
    }
}
