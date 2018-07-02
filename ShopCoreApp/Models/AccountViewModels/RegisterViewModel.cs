using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCoreApp.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Bạn phải nhập Họ và tên", AllowEmptyStrings = false)]
        [Display(Name = "Họ và tên")]
        public string FullName { set; get; }

        [Display(Name = "Ngày sinh")]
        public DateTime? BirthDay { set; get; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} phải nhập ít nhất {2} kí tự và nhiều nhất {1} kí tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Display(Name = "Điện thoại")]
        public string PhoneNumber { set; get; }

        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; }
    }
}
