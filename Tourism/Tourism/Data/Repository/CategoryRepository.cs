using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Data.interfaces;
using Tourism.Data.Models;

namespace Tourism.Data.Repository
{
    public class CategoryRepository : IRegionCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category.OrderBy(t => t.categoryName);
    }
}
