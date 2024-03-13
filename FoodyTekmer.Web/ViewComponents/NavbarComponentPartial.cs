using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.ViewComponents
{
    public class NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
