using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class Roles
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<MainUser> Users { get; set; }
    }
}
