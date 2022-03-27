using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using EMAProject.Domain.Entities;
using EMAProject.Domain.Repositories;
using EMAProject.Domain.Repositories.Abstract;
namespace EMAProject.Service
{
    public class ServiceItemService
    {
        private readonly IMongoCollection<ServiceItem> _serviceItems;
        
        public ServiceItemService (ISettingsDB settingsDB)
        {
            var client = new MongoClient(settingsDB.ConnectionString);
            var dBase = client.GetDatabase(settingsDB.DatabaseName);

            _serviceItems = dBase.GetCollection<ServiceItem>(settingsDB.ServiceItemCollection);
        }

        public List<ServiceItem> Get() => 
        _serviceItems.Find(serviceItem => true).ToList();

        public ServiceItem Get(string id) =>
        _serviceItems.Find<ServiceItem>(serviceItems => serviceItems.Id == id).FirstOrDefault();
        public ServiceItem Create(ServiceItem serviceItem)
        {
            _serviceItems.InsertOne(serviceItem);
            return serviceItem;
        }
        
    }
}