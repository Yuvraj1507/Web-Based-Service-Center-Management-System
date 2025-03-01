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
    public class ShopCartController : Controller 
    {
        private  IAllServices _serviceRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllServices serviceRep, ShopCart shopCart)
        {
            _serviceRep = serviceRep;
            _shopCart = shopCart;

        }
         
        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopServiceViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);

            
        }
        public RedirectToActionResult addToCart(int id)
        {
            var item = _serviceRep.Services.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
