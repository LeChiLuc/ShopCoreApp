using ShopCoreApp.Application.ViewModels;
using ShopCoreApp.Application.ViewModels.Common;
using ShopCoreApp.Application.ViewModels.Product;
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

        ProductViewModel Add(ProductViewModel productVm);

        void Update(ProductViewModel productVm);

        void Delete(int id);

        ProductViewModel GetById(int id);

        void AddQuantity(int productId, List<ProductQuantityViewModel> quantities);

        List<ProductQuantityViewModel> GetQuantities(int productId);

        void AddImages(int productId, string[] images);

        List<ProductImageViewModel> GetImages(int productId);

        void ImportExcel(string filePath, int categoryId);

        List<ProductViewModel> GetAllToExport(int? categoryId, string keyword);
        void Save();

        //void AddWholePrice(int productId, List<WholePriceViewModel> wholePrices);

        //List<WholePriceViewModel> GetWholePrices(int productId);

        List<ProductViewModel> GetLastest(int top);

        List<ProductViewModel> GetHotProduct(int top);
        List<ProductViewModel> GetRelatedProducts(int id, int top);

        List<ProductViewModel> GetUpsellProducts(int top);

        List<TagViewModel> GetProductTags(int productId);

        bool CheckAvailability(int productId, int size, int color);
    }
}
