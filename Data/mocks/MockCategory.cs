using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : IServicesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
new Category {categoryName = "Повне обслуговування", desc = "Повне та комплексне обслуговування програмних систем та комплексів" },
new Category {categoryName = "Вибіркове обслуговування", desc = "Оберіть певну послугу та складіть свій пакет"}
                };
            }
        }
    }
}
