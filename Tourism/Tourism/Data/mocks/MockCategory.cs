using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Data.interfaces;
using Tourism.Data.Models;

namespace Tourism.Data.mocks
{
    public class MockCategory : IRegionCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Київ"},
                    new Category { categoryName = "Вінницька"},
                    new Category { categoryName = "Волинська"},
                    new Category { categoryName = "Дніпропертовська"},
                    new Category { categoryName = "Донецька"},
                    new Category { categoryName = "Житомирська"},
                    new Category { categoryName = "Закарпатська"},
                    new Category { categoryName = "Запорізька"},
                    new Category { categoryName = "Івано-Франківська"},
                    new Category { categoryName = "Київська"},
                    new Category { categoryName = "Кіровоградська"},
                    new Category { categoryName = "Луганська"},
                    new Category { categoryName = "Львівська"},
                    new Category { categoryName = "Миколаївська"},
                    new Category { categoryName = "Одеська"},
                    new Category { categoryName = "Полтавська"},
                    new Category { categoryName = "Рівненська"},
                    new Category { categoryName = "Сумська"},
                    new Category { categoryName = "Тернопільська"},
                    new Category { categoryName = "Харківська"},
                    new Category { categoryName = "Херсонська"},
                    new Category { categoryName = "Хмельницька"},
                    new Category { categoryName = "Черкаська"},
                    new Category { categoryName = "Чернівецька"},
                    new Category { categoryName = "Чернігівська"}
                };
            }
        }

    }
}
