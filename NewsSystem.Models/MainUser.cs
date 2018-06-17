using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class MainUser
    {
        public int UserId { get; set; }
        [MaxLength(100) , Required(ErrorMessage = "username is required")]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [MaxLength(50)]
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required") , DataType(DataType.Password)]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        [Required , StringLength(100, MinimumLength = 6) , DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "تلفن")]
        public int phone { get; set; }
        public bool UserEnable { get; set; }
        [Display(Name = "آخرین ورود")]
        public DateTime LastLogOn { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
        public virtual UserSetting UserSetting { get; set; }
        public virtual ICollection<MediaFile> Media { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        //TODO Create Relation between Article and MainUser 
    }
}
