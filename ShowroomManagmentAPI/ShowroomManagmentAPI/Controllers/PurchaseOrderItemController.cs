using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderItemController : ControllerBase
    {
         private readonly IPurchaseOrderItem service;
        public PurchaseOrderItemController(IPurchaseOrderItem service)
        {
            this.service = service;

        }

        [HttpGet("GetPurchaseOrderItem")]
        public async Task<string> GetPurchaseOrderItem()
        {
            return JsonConvert.SerializeObject(await service.GetPurchaseOrderItem());
        }

        [HttpPost("AddPurchaseOrderItem")]
        public async Task<string> AddPurchaseOrderItem(PurchaseOrderItemDTO PurchaseOrderItemDTO)
        {
            return JsonConvert.SerializeObject(await service.AddPurchaseOrderItem(PurchaseOrderItemDTO));
        }

        [HttpGet("DeletePurchaseOrderItem/{id}")]
        public async Task<string> DeletePurchaseOrderItem(int Id)
        {
            return JsonConvert.SerializeObject(await service.DeletePurchaseOrderItem(Id));
        }

        [HttpGet("GetPurchaseOrderItemById/{id}")]
        public async Task<string> GetPurchaseOrderItemById(int Id)
        {
            return JsonConvert.SerializeObject(await service.GetPurchaseOrderItemById(Id));
        }

        [HttpPost("UpdatePurchaseOrderItem")]
        public async Task<string> UpdatePurchaseOrderItem(PurchaseOrderItemDTO PurchaseOrderItemDTO)
        {
            return JsonConvert.SerializeObject(await service.UpdatePurchaseOrderItem(PurchaseOrderItemDTO));
        }
    }
}
