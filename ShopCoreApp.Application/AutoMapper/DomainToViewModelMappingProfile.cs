using AutoMapper;
using ShopCoreApp.Application.ViewModels;
using ShopCoreApp.Application.ViewModels.Product;
using ShopCoreApp.Application.ViewModels.System;
using ShopCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Function, FunctionViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<AppUser, AppUserViewModel>();
            CreateMap<AppRole, AppRoleViewModel>();
            CreateMap<Bill, BillViewModel>().MaxDepth(2);
            CreateMap<BillDetail, BillDetailViewModel>().MaxDepth(2);
            CreateMap<Color, ColorViewModel>().MaxDepth(2);
            CreateMap<Size, SizeViewModel>().MaxDepth(2);
        }
    }
}
