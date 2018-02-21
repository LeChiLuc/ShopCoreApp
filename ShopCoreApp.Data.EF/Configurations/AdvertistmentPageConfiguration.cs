using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCoreApp.Data.EF.Extensions;
using ShopCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCoreApp.Data.EF.Configurations
{
    public class AdvertistmentPageConfiguration : DbEntityConfiguration<AdvertistmentPage>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPage> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired().HasColumnType("nvarchar(20)");
        }
    }
}
