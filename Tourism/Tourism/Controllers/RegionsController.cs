using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tourism.Data.interfaces;
using Tourism.Data.Models;
using Tourism.ViewModels;

namespace Tourism.Controllers
{
    public class RegionsController : Controller
    {
        private readonly IAllRegions _allRegions;
        private readonly IRegionCategory _regionCategory;

        public RegionsController(IAllRegions iAllRegions, IRegionCategory iRegionCategory)
        {
            _allRegions = iAllRegions;
            _regionCategory = iRegionCategory;
        }
        [Route("Regions/List")]
        [Route("Regions/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Region> region = null;
            IEnumerable<Category> categories = _regionCategory.AllCategories;
            string currCategory = "";

            foreach (Category item in categories)
            {
                if (string.Equals(item.categoryName, category, StringComparison.OrdinalIgnoreCase))
                {
                    region = _allRegions.Regions.Where(i => i.Category.categoryName.Equals(item.categoryName));
                    currCategory = item.categoryName;
                }
            }

            ViewBag.Title = "Музей туризму";
            RegionsListViewModel obj = new RegionsListViewModel
            {
                allRegions = region,
                allCategories = categories,
                currCategory = currCategory
            };
            return View(obj);
        }
    }
}