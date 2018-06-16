using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        [ForeignKey("ParentId")]
        public virtual Menu Parent { get; set; }
        public virtual ICollection<MediaFile> Media { get; set; }
    }
}
