using Microsoft.AspNetCore.Mvc.Rendering;
using ShopCoreApp.Application.ViewModels;
using ShopCoreApp.Application.ViewModels.Common;
using ShopCoreApp.Application.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCoreApp.Views.Product
{
    public class DetailViewModel
    {
        public ProductViewModel Product { get; set; }

        public bool Available { set; get; }

        public List<ProductViewModel> RelatedProducts { get; set; }

        public ProductCategoryViewModel Category { get; set; }

        public List<ProductImageViewModel> ProductImages { set; get; }

        public List<ProductViewModel> UpsellProducts { get; set; }

        public List<ProductViewModel> LastestProducts { get; set; }

        public List<TagViewModel> Tags { set; get; }

        public List<SelectListItem> Colors { set; get; }

        public List<SelectListItem> Sizes { set; get; }
    }
}
