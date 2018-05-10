using ShopCoreApp.Application.ViewModels.System;
using ShopCoreApp.Data.Entities;
using ShopCoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopCoreApp.Application.ViewModels.Product
{
    public class BillViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        public PaymentMethod PaymentMethod { set; get; }

        public BillStatus BillStatus { set; get; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        public Status Status { set; get; } = Status.Active;

        public Guid? CustomerId { set; get; }

        public AppUserViewModel User { set; get; }

        public List<BillDetailViewModel> BillDetails { set; get; }
    }
}
