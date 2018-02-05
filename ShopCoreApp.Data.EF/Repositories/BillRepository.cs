using System;
using System.Collections.Generic;
using System.Text;
using ShopCoreApp.Data.Entities;
using ShopCoreApp.Data.IRepositories;

namespace ShopCoreApp.Data.EF.Repositories
{
    public class BillRepository : EFRepository<Bill, int>, IBillRepository
    {
        public BillRepository(AppDbContext context) : base(context)
        {
        }
    }
}
