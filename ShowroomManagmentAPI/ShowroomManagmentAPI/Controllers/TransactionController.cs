using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransaction service;
        public TransactionController(ITransaction service)
        {
            this.service = service;
        }
        [HttpGet("GetTransaction")]
        public async Task<string> GetTransaction()
        {
            return JsonConvert.SerializeObject(await this.service.GetTransaction());
        }
        [HttpPost("AddTransaction")]
        public async Task<string> AddTransaction(TransactionDTO transactionDTO)
        {
            return JsonConvert.SerializeObject(await this.service.AddTransaction(transactionDTO));
        }
        [HttpGet("GetTransactionById/{id}")]
        public async Task<string> GetTransactionById(int id)
        {
            return JsonConvert.SerializeObject(await this.service.GetTransactionById(id));
        }
        [HttpGet("DeleteTransaction/{id}")]
        public async Task<string> DeleteTransaction(int id)
        {
            return JsonConvert.SerializeObject(await this.service.DeleteTransaction(id));
        }
        [HttpPost("UpdateTransaction")]
        public async Task<string> UpdateTransaction(TransactionDTO transactionDTO)
        {
            return JsonConvert.SerializeObject(await this.service.UpdateTransaction(transactionDTO));
        }
    }
}
