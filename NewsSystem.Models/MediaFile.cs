using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class MediaFile
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string FileTitle { get; set; }
        public string FileDescription { get; set; }
        public string Extension { get; set; }
        public string FileMimeType { get; set; }
        public string FilePath { get; set; }
        public int FileSize { get; set; }
        public DateTime FileCreatedDate { get; set; }
        public DateTime FileModifiedDate { get; set; }
        public virtual MainUser Users { get; set; }
        public virtual ICollection<Library> Library { get; set; }
        public virtual ICollection<SocialNetworks> SocialNetworks { get; set; }
        public virtual Article Article { get; set; }
        //TODO Create Relation between Article and MediaFile 
        public virtual Menu Menu { get; set; }
    }
}
