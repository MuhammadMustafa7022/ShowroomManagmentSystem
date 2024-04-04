using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItem service;
        public OrderItemController(IOrderItem service)
        {
            this.service = service;

        }

        [HttpGet("GetOrderItem")]
        public async Task<string> GetOrderItem()
        {
            return JsonConvert.SerializeObject(await service.GetOrderItem());
        }

        [HttpPost("AddOrderItem")]
        public async Task<string> AddOrderItem(OrderItemDTO orderItemDTO)
        {
            return JsonConvert.SerializeObject(await service.AddOrderItem(orderItemDTO));
        }

        [HttpGet("DeleteOrderItem/{id}")]
        public async Task<string> DeleteOrderItem(int Id)
        {
            return JsonConvert.SerializeObject(await service.DeleteOrderItem(Id));
        }

        [HttpGet("GetOrderItemById/{id}")]
        public async Task<string> GetOrderItemById(int Id)
        {
            return JsonConvert.SerializeObject(await service.GetOrderItemById(Id));
        }

        [HttpPost("UpdateOrderItem")]
        public async Task<string> UpdateOrderItem(OrderItemDTO orderItemDTO)
        {
            return JsonConvert.SerializeObject(await service.UpdateOrderItem(orderItemDTO));
        }
    }
}
