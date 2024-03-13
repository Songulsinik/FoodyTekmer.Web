using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Web.ViewComponents
{
    public class ProductListComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public ProductListComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke() 
        {
            var values = _productService.TGetAllList();
            return View(values); 
        }
    }
}
