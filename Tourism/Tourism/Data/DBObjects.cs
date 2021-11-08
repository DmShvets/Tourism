using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Data.Models;

namespace Tourism.Data
{
    public class DBObjects
    {
        public static void Initaial(AppDBContent content)
        { 
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Region.Any())
            {
                content.AddRange(
                    new Region
                    {
                        name = "Київ",
                        img = "/img/kyiv_slider1.jpg",
                        description = "",
                        map = "",
                        Category = Categories["Київ"]
                    },
                    new Region
                    {
                        name = "Вінницька",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Вінницька"]
                    },
                    new Region
                    {
                        name = "Волинська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Волинська"]
                    },
                    new Region
                    {
                        name = "Дніпропертовська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Дніпропертовська"]
                    },
                    new Region
                    {
                        name = "Донецька",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Донецька"]
                    },
                    new Region
                    {
                        name = "Житомирська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Житомирська"]
                    },
                    new Region
                    {
                        name = "Закарпатська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Закарпатська"]
                    },
                    new Region
                    {
                        name = "Запорізька",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Запорізька"]
                    },
                    new Region
                    {
                        name = "Івано-Франківська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Івано-Франківська"]
                    },
                    new Region
                    {
                        name = "Київська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Київська"]
                    },
                    new Region
                    {
                        name = "Кіровоградська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Кіровоградська"]
                    },
                    new Region
                    {
                        name = "Луганська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Луганська"]
                    },
                    new Region
                    {
                        name = "Львівська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Львівська"]
                    },
                    new Region
                    {
                        name = "Миколаївська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Миколаївська"]
                    },
                    new Region
                    {
                        name = "Одеська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Одеська"]
                    },
                    new Region
                    {
                        name = "Полтавська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Полтавська"]
                    },
                    new Region
                    {
                        name = "Рівненська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Рівненська"]
                    },
                    new Region
                    {
                        name = "Сумська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Сумська"]
                    },
                    new Region
                    {
                        name = "Тернопільська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Тернопільська"]
                    },
                    new Region
                    {
                        name = "Харківська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Харківська"]
                    },
                    new Region
                    {
                        name = "Херсонська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Херсонська"]
                    },
                    new Region
                    {
                        name = "Хмельницька",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Хмельницька"]
                    },
                    new Region
                    {
                        name = "Черкаська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Черкаська"]
                    },
                    new Region
                    {
                        name = "Чернівецька",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Чернівецька"]
                    },
                    new Region
                    {
                        name = "Чернігівська",
                        img = "",
                        description = "",
                        map = "",
                        Category = Categories["Чернігівська"]
                    }
                );
            }

            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
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

                    category = new Dictionary<string, Category>();
                    foreach (Category item in list)
                        category.Add(item.categoryName, item);
                }
                return category;
            }
        }
    }
}
