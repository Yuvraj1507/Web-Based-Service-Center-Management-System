using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private IAllServices _serviceRep;
        

        public HomeController(IAllServices serviceRep)
        {
            _serviceRep = serviceRep;
        }
        public ViewResult Index()
        {
            var homeServices = new HomeViewModel
            {
            favServices = _serviceRep.getFavServices
            };
            return View(homeServices);
        }

    }
}
