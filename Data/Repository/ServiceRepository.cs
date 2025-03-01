using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class ServiceRepository : IAllServices
    {
        private readonly AppDBContent appDBContent;
        public ServiceRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Service> Services => appDBContent.Service.Include(c => c.Category);

        public IEnumerable<Service> getFavServices => appDBContent.Service.Where(p => p.isFavorite).Include(c => c.Category);

        public Service getObjectService(int serviceID) => appDBContent.Service.FirstOrDefault(p => p.id == serviceID);
        
            
        
    }
}
