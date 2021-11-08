using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Data.Models;

namespace Tourism.ViewModels
{
    public class RegionsListViewModel
    {
        public IEnumerable<Region> allRegions { get; set; }

        public IEnumerable<Category> allCategories { get; set; }

        public string currCategory { get; set; }

    }
}
