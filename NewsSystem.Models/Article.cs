using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public virtual Category Categories { get; set; }
        public virtual ICollection<MediaFile> Media { get; set; }
        //TODO Create Relation between Article and MediaFile
        public virtual MainUser Users { get; set; }
        //TODO Create Relation between Article and MainUser 
    }
}
