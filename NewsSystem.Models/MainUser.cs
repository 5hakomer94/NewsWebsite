using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    [Table("Users" , Schema = "User")]
    public class MainUser
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "لطفا نام خود را وارد نمایید.")]
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "لطفا نام خانوادگی خود را وارد نمایید.")]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "لطفا ایمیل خود را وارد نمایید.")]
        [Display(Name = "ایمیل")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")]
        public string Email { get; set; }
        [StringLength(100, MinimumLength = 6) , DataType(DataType.Password)]
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [Display(Name = "تلفن")]
        public int phone { get; set; }
        [Display(Name = "جنسیت")]
        public string Gender { get; set; }
        public string ProfilePicPath { get; set; }
        public bool UserEnable { get; set; }
        [Display(Name = "آخرین ورود")]
        public DateTime LastLogOn { get; set; }
        //Relations - Navigation Properties
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<MediaFile> Media { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<EventCategory> EventCategories { get; set; }
        public virtual ICollection<EventTag> EventTags { get; set; }
        public virtual ICollection<NewsCategory> NewsCategories { get; set; }
        public virtual ICollection<NewsTag> NewsTags { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }

    }
}
