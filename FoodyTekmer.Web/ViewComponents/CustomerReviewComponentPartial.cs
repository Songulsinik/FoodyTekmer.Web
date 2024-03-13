using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.ViewComponents
{
    public class CustomerReviewComponentPartial:ViewComponent
    {
        private readonly ICustomerReviewService _customerReviewService;

        public CustomerReviewComponentPartial(ICustomerReviewService customerReviewService)
        {
            _customerReviewService = customerReviewService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _customerReviewService.TGetAllList();
            return View(values);
        }
    }
}
