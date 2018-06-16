using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class NewsLetterSubscriber
    {
        public int SubscriberId { get; set; }
        [Required(ErrorMessage = "Email is required"), DataType(DataType.Password)]
        public string Email { get; set; }
    }
}
