using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class UserSetting
    {
        public int Id { get; set; }
        public string Signature { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public virtual MainUser Users { get; set; }
        public virtual UserPicture UserPictures { get; set; }
    }
}
