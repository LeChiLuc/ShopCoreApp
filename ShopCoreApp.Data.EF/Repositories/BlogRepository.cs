using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopCoreApp.Data.Entities;
using ShopCoreApp.Data.Enums;
using ShopCoreApp.Data.IRepositories;

namespace ShopCoreApp.Data.EF.Repositories
{
    public class BlogRepository : EFRepository<Blog, int>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context)
        {
        }
    }
}
