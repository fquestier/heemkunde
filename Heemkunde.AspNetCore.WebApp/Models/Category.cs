using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Heemkunde.AspNetCore.WebApp.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name = "Hoofdcategorie")]
        public int? MainCategoryID { get; set; }

        [Required]
        [Display(Name = "Naam")]
        public string Name { get; set; }

        [Display(Name = "Omschrijving")]
        public string Description { get; set; }

        // Navigational properties
        [Display(Name = "Hoofdcategorie")]
        public Category MainCategory { get; set; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<Element> Elements { get; set; }

        public ICollection<ObjectCategory> ObjectCategories { get; set; }
    }
}
