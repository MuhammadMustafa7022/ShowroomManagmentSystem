using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderController : ControllerBase
    {
        private readonly ISaleOrder service;
        public SalesOrderController(ISaleOrder service)
        {
            this.service = service;

        }

        [HttpGet("GetSaleOrder")]
        public async Task<string> GetSaleOrder()
        {
            return JsonConvert.SerializeObject(await service.GetSaleOrder());
        }

        [HttpPost("AddSaleOrder")]
        public async Task<string> AddSaleOrder(SalesOrderDTO salesOrderDTO)
        {
            return JsonConvert.SerializeObject(await service.AddSaleOrder(salesOrderDTO));
        }

        [HttpGet("DeleteSaleOrder/{id}")]
        public async Task<string> DeleteSaleOrder(int Id)
        {
            return JsonConvert.SerializeObject(await service.DeleteSaleOrder(Id));
        }

        [HttpGet("GetSaleOrderById/{id}")]
        public async Task<string> GetSaleOrderById(int Id)
        {
            return JsonConvert.SerializeObject(await service.GetSaleOrderById(Id));
        }

        [HttpPost("UpdateSaleOrder")]
        public async Task<string> UpdateSaleOrder(SalesOrderDTO salesOrderDTO)
        {
            return JsonConvert.SerializeObject(await service.UpdateSaleOrder(salesOrderDTO));
        }

    }
}
