﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopCoreApp.Application.ViewModels.Product
{
    public class SizeViewModel
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Name
        {
            get; set;
        }
    }
}
