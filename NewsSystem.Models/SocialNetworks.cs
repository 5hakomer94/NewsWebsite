using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class SocialNetworks
    {
        public int SocialId { get; set; }
        public string SnName { get; set; }
        public string SnUrl { get; set; }
        public virtual ICollection<MediaFile> Media { get; set; }
    }
}
