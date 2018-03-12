using ShopCoreApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
    }
}
