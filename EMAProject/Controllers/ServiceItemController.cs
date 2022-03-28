using EMAProject.Service;
using EMAProject.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EMAProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceItemController : ControllerBase
    {
        private readonly ServiceItemService _serviceItemService;

        public ServiceItemController(ServiceItemService serviceItemService)
        {
            _serviceItemService = serviceItemService;
        }

        [HttpGet]
        public ActionResult<List<ServiceItem>>Get() => _serviceItemService.Get();
        
        [HttpGet("{id:length(24)}", Name = "GetServiceItem")]
        public ActionResult<ServiceItem> Get(string id)
        {
            var serviceItem = _serviceItemService.Get(id);
            if (serviceItem == null)
            {
                return NotFound();
            }
            return serviceItem;
        }

        [HttpPost]
        public ActionResult<ServiceItem> Create(ServiceItem serviceItem)
        {
            _serviceItemService.Create(serviceItem);
            return CreatedAtRoute("GetServiceItem", new {id = serviceItem.Id.ToString()},serviceItem);
        }

        [HttpPut]
        public ActionResult<ServiceItem> Update(string id , ServiceItem serviceItemIn)
        {
            var serviceItem = _serviceItemService.Get(id);
            if (serviceItem == null)
            {
                return NotFound();
            }

            _serviceItemService.Update(id,serviceItemIn);
            
            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var serviceItem = _serviceItemService.Get(id);
            if (serviceItem == null)
            {
                return NotFound();
            }

            _serviceItemService.Remove(id);
            
            return NoContent();
        }
    }
}