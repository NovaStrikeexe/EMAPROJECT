using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using EMAProject.Domain.Repositories.Abstract;
namespace EMAProject.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields{get;set;}
        public IServiceItemRepository ServiceItems{ get; set;}

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemRepository serviceItemRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemRepository;
        }
    }
}