using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCoreApp.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Nhớ mật khẩu?")]
        public bool RememberMe { get; set; }
    }
}
