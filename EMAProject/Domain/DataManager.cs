using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using EMAProject.Domain.Repositories.Abstract;

using EMAProject.Service;
namespace EMAProject.Domain
{
    public class DataManager
    {
        public TextFieldService TextFields{get;set;}
        public ServiceItemService ServiceItems{ get; set;}

        public DataManager(TextFieldService textFieldsService, ServiceItemService serviceItemService)
        {
            TextFields = textFieldsService;
            ServiceItems = serviceItemService;
        }
    }
}