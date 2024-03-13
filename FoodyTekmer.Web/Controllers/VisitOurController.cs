using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.Controllers
{
    public class VisitOurController : Controller
    {
        private readonly IVisitOurFirmService _visitOurFirmService;

        public VisitOurController(IVisitOurFirmService visitOurFirmService)
        {
            _visitOurFirmService = visitOurFirmService;
        }

        public IActionResult Index()
        {
            var values=_visitOurFirmService.TGetAllList();
            return View(values);
        }
    }
}
