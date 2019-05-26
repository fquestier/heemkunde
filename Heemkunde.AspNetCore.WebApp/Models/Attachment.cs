using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Heemkunde.AspNetCore.WebApp.Models
{
    public class Attachment
    {
        public int ID { get; set; }

        public int ObjectID { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public string BlobName { get; set; }

        // Navigational properties
        public Object Object { get; set; }
    }
}
