using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IAllServices _allServices;
        private readonly IServicesCategory _allCategories;

        public ServicesController (IAllServices iAllServices, IServicesCategory iServicesCat)
        {
            _allServices = iAllServices;
            _allCategories = iServicesCat;
        }
        [Route("Service/List")]
        [Route("Service/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Service> services = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                services = _allServices.Services.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("FullService", category, StringComparison.OrdinalIgnoreCase))
                {
                    services = _allServices.Services.Where(i => i.Category.categoryName.Equals("Повне обслуговування")).OrderBy(i => i.id);
                    currCategory = "Повне обслуговування";
                }
                else if (string.Equals("SelectiveService", category, StringComparison.OrdinalIgnoreCase))
                {
                    services = _allServices.Services.Where(i => i.Category.categoryName.Equals("Вибіркове обслуговування")).OrderBy(i => i.id);
                    currCategory = "Вибіркове обслуговування";
                }
                

               
            }

            var serviceObj = new ServicesListViewModel
            {
                allServices = services,
                currCategory = currCategory
            };
            ViewBag.Title = "Сторінка з послугами";
           
            
            return View(serviceObj);
        }

    }
}
