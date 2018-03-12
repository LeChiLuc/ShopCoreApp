using AutoMapper;
using ShopCoreApp.Application.ViewModels;
using ShopCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCoreApp.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductCategoryViewModel, ProductCategory>()
                .ConstructUsing(c => new ProductCategory());
            CreateMap<ProductViewModel, Product>()
                .ConstructUsing(c => new Product());
        }
    }
}
