using AutoMapper;
using ShopCoreApp.Application.ViewModels;
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
        }
    }
}
