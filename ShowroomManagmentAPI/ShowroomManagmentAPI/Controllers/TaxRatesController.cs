using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxRatesController : ControllerBase
    {
        private readonly ITaxRates service;
        public TaxRatesController(ITaxRates service)
        {
            this.service = service;
        }
        [HttpGet("GetTaxRates")]
        public async Task<string> GetTaxRates()
        {
            return JsonConvert.SerializeObject(await this.service.GetTaxRates());
        }
        [HttpPost("AddTaxRates")]
        public async Task<string> AddTaxRates(TaxRateDTO taxRateDTO)
        {
            return JsonConvert.SerializeObject(await this.service.AddTaxRates(taxRateDTO));
        }
        [HttpGet("GetTaxRatesById/{id}")]
        public async Task<string> GetTaxRatesById(int id)
        {
            return JsonConvert.SerializeObject(await this.service.GetTaxRatesById(id));
        }
        [HttpGet("DeleteTaxRates/{id}")]
        public async Task<string> DeleteTaxRates(int id)
        {
            return JsonConvert.SerializeObject(await this.service.DeleteTaxRates(id));
        }
        [HttpPost("UpdateTaxRates")]
        public async Task<string> UpdateTaxRates(TaxRateDTO taxRateDTO)
        {
            return JsonConvert.SerializeObject(await this.service.UpdateTaxRates(taxRateDTO));
        }
    }
}
