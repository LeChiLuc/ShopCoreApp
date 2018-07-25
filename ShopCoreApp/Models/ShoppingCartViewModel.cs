using ShopCoreApp.Application.ViewModels;
using ShopCoreApp.Application.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCoreApp.Models
{
    public class ShoppingCartViewModel
    {
        public ProductViewModel Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public ColorViewModel Color { set; get; }
        public SizeViewModel Size { set; get; }
    }
}
