using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Data.Models
{
    public class Region
    {
        public int id { get; set; }

        public string name { get; set; }

        public string img { get; set; }

        public string description { get; set; }

        public string map { get; set; }

        public int categoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
