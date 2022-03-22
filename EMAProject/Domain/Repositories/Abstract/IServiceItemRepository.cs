using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using EMAProject.Domain.Entities;
namespace EMAProject.Domain.Repositories.Abstract
{
    public interface IServiceItemRepository
    {
         IQueryable<ServiceItem>GetServiceItems();
         ServiceItem GetServiceItemById(string id);
         void SaveServiceItem(ServiceItem entity);
         void DeleteServiceItem(string id);
    }

}