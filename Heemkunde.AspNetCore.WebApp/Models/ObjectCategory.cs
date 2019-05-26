using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heemkunde.AspNetCore.WebApp.Models
{
    public class ObjectCategory
    {
        public int ID { get; set; }

        public int ObjectID { get; set; }

        public int CategoryID { get; set; }

        // Navigational properties
        public Object Object { get; set; }

        public Category Category { get; set; }
    }
}
