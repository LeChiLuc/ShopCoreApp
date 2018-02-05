using System;
using System.Collections.Generic;
using System.Text;
using ShopCoreApp.Data.Entities;
using ShopCoreApp.Infrastructure.Interfaces;

namespace ShopCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
