using ShopCoreApp.Application.ViewModels;
using ShopCoreApp.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword,int page, int pageSize);
    }
}
