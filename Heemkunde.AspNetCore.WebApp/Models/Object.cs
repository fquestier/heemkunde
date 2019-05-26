using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Heemkunde.AspNetCore.WebApp.Models
{
    public class Object
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigational properties
        public ICollection<ObjectElement> ObjectElements { get; set; }

        public ICollection<ObjectCategory> ObjectCategories { get; set; }

        public ICollection<Attachment> Attachments { get; set; }
    }
}
