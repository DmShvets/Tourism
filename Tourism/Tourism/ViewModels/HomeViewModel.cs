using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Data.Models;

namespace Tourism.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Category> allCategories { get; set; }
    }
}
