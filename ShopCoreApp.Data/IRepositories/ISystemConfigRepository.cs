using System;
using System.Collections.Generic;
using System.Text;
using ShopCoreApp.Data.Entities;
using ShopCoreApp.Infrastructure.Interfaces;

namespace ShopCoreApp.Data.IRepositories
{
    public interface ISystemConfigRepository : IRepository<SystemConfig, string>
    {
    }
}
