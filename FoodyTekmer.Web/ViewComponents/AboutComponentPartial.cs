using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.ViewComponents
{
    public class AboutComponentPartial:ViewComponent
    {
        private readonly IAboutService _aboutService;
        public AboutComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        public IViewComponentResult Invoke()
        {
            var values= _aboutService.TGetAllList();
            return View(values);
        }
    }
}
