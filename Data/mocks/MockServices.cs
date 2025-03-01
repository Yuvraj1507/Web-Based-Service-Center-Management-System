using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockServices : IAllServices
    {
            private readonly IServicesCategory _categoryServices = new MockCategory();
        public IEnumerable<Service> Services
        {
            get
            {
                return new List<Service>
                {
                    new Service {
                        name = "Очистка",
                        shortDesc = "Розбір комп'ютера та очистка від пилу",
                        longDesc = "Повна розбірка комп'ютера/ноутбука та очистка від пилу.",
                        img = "",
                        price = 150,
                        isFavorite = true,
                        Category = _categoryServices.AllCategories.First()
                },
                new Service
                {
                        name = "Програмна очистка",
                        shortDesc = "Діагностика та оптимізація",
                        longDesc = "Проводиться повна діагностика ПК та в залежності від неї відбувається програмна очистка",
                        img = "",
                        price = 150,
                        isFavorite = true,
                        Category = _categoryServices.AllCategories.Last()
                },
                new Service
                {
                        name = "Діагностика комп'ютера",
                        shortDesc = "Повна діагностика ПК",
                        longDesc = "Повна діагностика роботоздатності комп'ютера та усунення неполадок",
                        img = "",
                        price = 300,
                        isFavorite = true,
                        Category = _categoryServices.AllCategories.First()
                },
                new Service
                {
                        name = "Апаратний ремонт",
                        shortDesc = "Апаратний ремонт компонентів",
                        longDesc = "Ремонт компонентів комп'ютера",
                        img = "",
                        price = 500,
                        isFavorite = true,
                        Category = _categoryServices.AllCategories.First()
                }
            };
            }
        }
        public IEnumerable<Service> getFavServices { get; set; }

        public Service getObjectService(int serviceID)
        {
            throw new NotImplementedException();
        }
    }
}
