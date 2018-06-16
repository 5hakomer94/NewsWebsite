using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class Library
    {
        public int LibraryId { get; set; }
        [MaxLength(150)]
        public string LibraryName { get; set; }
        public virtual ICollection<MediaFile> MediaFiles { get; set; }

    }
}
