using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.ViewComponents
{
    public class FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
