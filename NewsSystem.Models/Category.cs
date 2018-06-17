using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<AnnonymousUser> OtherUsers { get; set; }
    }
}
