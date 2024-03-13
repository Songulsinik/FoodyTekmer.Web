using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.ViewComponents
{
    public class ContactUsComponentPartial:ViewComponent
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsComponentPartial(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_contactUsService.TGetAllList();
            return View(values);
        }
    }
}
