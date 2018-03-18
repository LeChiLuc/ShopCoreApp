using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopCoreApp.Application.Interfaces;

namespace ShopCoreApp.Areas.Admin.Controllers
{
    public class ProductCategoryController : BaseController
    {
        public IProductCategoryService _productCategoryService;
        public ProductCategoryController( IProductCategoryService productCategoryService)
        {         
            _productCategoryService = productCategoryService;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Get Data API
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productCategoryService.GetAll();
            return new OkObjectResult(model);
        }
        #endregion
    }
}