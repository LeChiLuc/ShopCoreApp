using ShopCoreApp.Application.ViewModels.Common;
using ShopCoreApp.Application.ViewModels.Product;
using ShopCoreApp.Data.Enums;
using ShopCoreApp.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCoreApp.Models
{
    public class CheckoutViewModel : BillViewModel
    {
        public List<ShoppingCartViewModel> Carts { get; set; }
        public List<EnumModel> PaymentMethods
        {
            get
            {
                return ((PaymentMethod[])Enum.GetValues(typeof(PaymentMethod)))
                    .Select(c => new EnumModel
                    {
                        Value = (int)c,
                        Name = c.GetDescription()
                    }).ToList();
            }
        }
    }
}
