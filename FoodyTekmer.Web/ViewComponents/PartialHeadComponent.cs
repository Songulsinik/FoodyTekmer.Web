using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.ViewComponents
{
    public class PartialHeadComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
