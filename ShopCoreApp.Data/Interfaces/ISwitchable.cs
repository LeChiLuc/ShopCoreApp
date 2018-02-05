using System;
using System.Collections.Generic;
using System.Text;
using ShopCoreApp.Data.Enums;

namespace ShopCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
