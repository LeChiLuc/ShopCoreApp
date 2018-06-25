using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopCoreApp.Controllers
{
    public class ProductController : Controller
    {
        [Route("product.html")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("{alias}-c.{id}.html")]
        public IActionResult Category(int id, string keyword, int? pageSize, string sortBy, int page = 1)
        {
            return View();
        }
    }
}