using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Data.interfaces;
using Tourism.Data.Models;

namespace Tourism.Data.mocks
{
    public class MockRegions : IAllRegions
    {
        private readonly IRegionCategory _categoryRegion = new MockCategory();
        public IEnumerable<Region> Regions
        {
            get
            {
                return new List<Region>
                {
                    new Region
                    {
                        name = "Київ",
                        img = "/img/kyiv_slider1.jpg",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(0)
                    },
                    new Region
                    {
                        name = "Вінницька",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(1)
                    },
                    new Region
                    {
                        name = "Волинська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(2)
                    },
                    new Region
                    {
                        name = "Дніпропертовська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(3)
                    },
                    new Region
                    {
                        name = "Донецька",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(4)
                    },
                    new Region
                    {
                        name = "Житомирська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(5)
                    },
                    new Region
                    {
                        name = "Закарпатська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(6)
                    },
                    new Region
                    {
                        name = "Запорізька",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(7)
                    },
                    new Region
                    {
                        name = "Івано-Франківська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(8)
                    },
                    new Region
                    {
                        name = "Київська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(9)
                    },
                    new Region
                    {
                        name = "Кіровоградська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(10)
                    },
                    new Region
                    {
                        name = "Луганська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(11)
                    },
                    new Region
                    {
                        name = "Львівська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(12)
                    },
                    new Region
                    {
                        name = "Миколаївська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(13)
                    },
                    new Region
                    {
                        name = "Одеська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(14)
                    },
                    new Region
                    {
                        name = "Полтавська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(15)
                    },
                    new Region
                    {
                        name = "Рівненська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(16)
                    },
                    new Region
                    {
                        name = "Сумська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(17)
                    },
                    new Region
                    {
                        name = "Тернопільська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(18)
                    },
                    new Region
                    {
                        name = "Харківська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(19)
                    },
                    new Region
                    {
                        name = "Херсонська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(20)
                    },
                    new Region
                    {
                        name = "Хмельницька",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(21)
                    },
                    new Region
                    {
                        name = "Черкаська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(22)
                    },
                    new Region
                    {
                        name = "Чернівецька",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(23)
                    },
                    new Region
                    {
                        name = "Чернігівська",
                        img = "",
                        description = "",
                        map = "",
                        Category = _categoryRegion.AllCategories.ElementAt(24)
                    }
                };
            }
        }

        public Region getObjectRegion(int regionID)
        {
            throw new NotImplementedException();
        }
    }
}
