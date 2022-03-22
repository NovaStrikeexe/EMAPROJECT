using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using EMAProject.Domain.Entities;
using Microsoft.Extensions.Caching.Memory;
using EMAProject.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace EMAProject.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository:IServiceItemRepository
    {
        private readonly AppDbContext context;
        private readonly IMemoryCache _memoryCache;
        public EFServiceItemsRepository(IMemoryCache memoryCache)
        { }
        public EFServiceItemsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems;
        }
        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItems.FirstOrDefault(x=> x.Id == id);
        }
        public void SaveServiceItem(ServiceItem entity)
        {
            if(entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            { 
                context.Entry(entity).State = EntityState.Modified; 
                context.SaveChanges(); 
            }
        }
        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems.Remove(new ServiceItem (){Id = id});
            context.SaveChanges();
        }
        
    }
}