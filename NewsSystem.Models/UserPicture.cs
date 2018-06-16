using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class UserPicture
    {
        public int PicId { get; set; }
        public string PicPath { get; set; }
        [FileExtensions(Extensions = "jpg,jpeg,png")]
        public string Extension { get; set; }
        public virtual UserSetting UserSetting { get; set; }
    }
}
