using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.Controllers
{
    public class CustomerReview : Controller
    {
        private readonly ICustomerReviewService _customerReviewService;

        public CustomerReview(ICustomerReviewService customerReviewService)
        {
            _customerReviewService = customerReviewService;
        }

        public IActionResult Index()
        {
            var values=_customerReviewService.TGetAllList();
            return View(values);
        }
    }
}
