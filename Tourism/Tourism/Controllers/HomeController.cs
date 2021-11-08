using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tourism.Data.interfaces;
using Tourism.ViewModels;

namespace Tourism.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRegionCategory _categoryRepos;
        public HomeController(IRegionCategory category)
        {
            _categoryRepos = category;
           
        }
        public ViewResult Index()
        {
            ViewBag.Title = "Музей туризму";
            HomeViewModel obj = new HomeViewModel();
            obj.allCategories = _categoryRepos.AllCategories;
            return View(obj);
        }
    }
}