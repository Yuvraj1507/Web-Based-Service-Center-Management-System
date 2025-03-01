using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial (AppDBContent content)
        {
           
           

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value ));

            if (!content.Service.Any())
            {
                content.AddRange(


                     new Service
                     {
                         name = "Очистка",
                         shortDesc = "Розбір комп'ютера та очистка від пилу",
                         longDesc = "Повна розбірка комп'ютера/ноутбука та очистка від пилу.",
                         img = "",
                         price = 150,
                         isFavorite = true,
                         Category = Categories["Вибіркове обслуговування"]
                     },
                new Service
                {
                    name = "Програмна очистка",
                    shortDesc = "Діагностика та оптимізація",
                    longDesc = "Проводиться повна діагностика ПК та в залежності від неї відбувається програмна очистка",
                    img = "",
                    price = 150,
                    isFavorite = true,
                    Category = Categories["Вибіркове обслуговування"]
                },
                new Service
                {
                    name = "Діагностика комп'ютера",
                    shortDesc = "Повна діагностика ПК",
                    longDesc = "Повна діагностика роботоздатності комп'ютера та усунення неполадок",
                    img = "",
                    price = 300,
                    isFavorite = true,
                    Category = Categories["Повне обслуговування"]
                },
                new Service
                {
                    name = "Апаратний ремонт",
                    shortDesc = "Апаратний ремонт компонентів",
                    longDesc = "Ремонт компонентів комп'ютера",
                    img = "",
                    price = 500,
                    isFavorite = true,
                    Category = Categories["Вибіркове обслуговування"]
                }


                    );
            }
            content.SaveChanges(); //Зберігаємо зміни в базі даних при запуску
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Повне обслуговування", desc = "Повне та комплексне обслуговування програмних систем та комплексів" },
                        new Category {categoryName = "Вибіркове обслуговування", desc = "Оберіть певну послугу та складіть свій пакет"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
