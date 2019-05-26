﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Heemkunde.AspNetCore.WebApp.Models
{
    public class ObjectElement
    {
        public int ID { get; set; }

        public int ObjectID { get; set; }

        public int ElementID { get; set; }

        [Required]
        public string Value { get; set; }

        // Navigational properties
        public Object Object { get; set; }

        public Element Element { get; set; }
    }
}
