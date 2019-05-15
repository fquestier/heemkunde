using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Heemkunde.AspNetCore.WebApp.Models
{
    public enum ElementType
    {
        Text, MultilineText, Number, Date, Year
    }

    public class Element
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }

        [Required]
        public string Name { get; set; }

        public ElementType Type { get; set; }
        public bool Mandatory { get; set; }

        public Category Category { get; set; }
    }
}
