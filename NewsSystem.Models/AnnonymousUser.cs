using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class AnnonymousUser
    {
        public int UserId { get; set; }
        [MaxLength(100), Required(ErrorMessage = "username is required")]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [MaxLength(50)]
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Display(Name = " نام خانوادگی")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required"), DataType(DataType.Password)]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        [Required, StringLength(100, MinimumLength = 6), DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        [Display(Name = "تلفن")]
        public int phone { get; set; }
    }
}
