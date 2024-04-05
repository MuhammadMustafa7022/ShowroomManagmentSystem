using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrdrController : ControllerBase
    {

        private readonly IPurchaseOrdr service;
        public PurchaseOrdrController(IPurchaseOrdr PurchaseOrdr)
        {
            this.service = PurchaseOrdr;
        }

        [HttpGet("GetPurchaseOrdr")]
        public async Task<string> GetPurchaseOrdr()
        {
            return JsonConvert.SerializeObject(await this.service.GetPurchaseOrdr());
        }
        [HttpPost("AddPurchaseOrdr")]
        public async Task<string> AddPurchaseOrdr(PurchaseOrdrDTO PurchaseOrdrDTO)
        {
            return JsonConvert.SerializeObject(await service.AddPurchaseOrdr(PurchaseOrdrDTO));

        }



        [HttpGet("GetPurchaseOrdrById/{id}")]
        public async Task<string> GetPurchaseOrdr(int id)
        {
            return JsonConvert.SerializeObject(await service.GetPurchaseOrdrById(id));
        }
        [HttpGet("DeletePurchaseOrdr/{id}")]
        public async Task<string> DeletePurchaseOrdr(int id)
        {
            return JsonConvert.SerializeObject(await service.DeletePurchaseOrdr(id));
        }
        [HttpPost("UpdatePurchaseOrdr")]
        public async Task<string> UpdatePurchaseOrdr(PurchaseOrdrDTO PurchaseOrdrDTO)
        {
            return JsonConvert.SerializeObject(await service.UpdatePurchaseOrdr(PurchaseOrdrDTO));
        }

    }
}
