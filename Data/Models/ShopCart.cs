using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public string ShopCartId { get; set; }
        public List<ShopServiceItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; //Створив сессію корзини
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart (Service service)
        {
            appDBContent.ShopServiceItem.Add(new ShopServiceItem
            {
                ShopCartId = ShopCartId,
                service = service,
                price = service.price
            });
            appDBContent.SaveChanges();
        }

        public List<ShopServiceItem> getShopItems()
        {
            return appDBContent.ShopServiceItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.service).ToList();
        }

    }
}
