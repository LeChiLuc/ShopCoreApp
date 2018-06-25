using Microsoft.AspNetCore.Mvc;
using ShopCoreApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCoreApp.Controllers.Components
{
    public class MainMenuViewComponent:ViewComponent
    {
        private IProductCategoryService _productCategoryService;
        public MainMenuViewComponent(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_productCategoryService.GetAll());
        }
    }
}
