using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.ViewComponents
{
    public class VisitOurComponentPartial:ViewComponent
    {
        private readonly IVisitOurFirmService _visitOurFirmService;

        public VisitOurComponentPartial(IVisitOurFirmService visitOurFirmService)
        {
            _visitOurFirmService = visitOurFirmService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_visitOurFirmService.TGetAllList();
            return View(values);
        }
    }
}
