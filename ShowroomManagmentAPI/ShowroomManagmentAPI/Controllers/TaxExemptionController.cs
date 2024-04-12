using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxExemptionController : ControllerBase
    {
        private readonly ITaxExemption service;
        public TaxExemptionController(ITaxExemption service)
        {
            this.service = service;
        }
        [HttpGet("GetTaxExemption")]
        public async Task<string> GetTaxExemption()
        {
            return JsonConvert.SerializeObject(await this.service.GetTaxExemption());
        }
        [HttpPost("AddTaxExemption")]
        public async Task<string> AddTaxExemption(TaxExemptionDTO taxExemptionDTO)
        {
            return JsonConvert.SerializeObject(await this.service.AddTaxExemption(taxExemptionDTO));
        }
        [HttpGet("GetTaxExemptionById/{id}")]
        public async Task<string> GetTaxRatesById(int id)
        {
            return JsonConvert.SerializeObject(await this.service.GetTaxExemptionById(id));
        }
        [HttpGet("DeleteTaxExemption/{id}")]
        public async Task<string> DeleteTaxExemption(int id)
        {
            return JsonConvert.SerializeObject(await this.service.DeleteTaxExemption(id));
        }
        [HttpPost("UpdateTaxExemption")]
        public async Task<string> UpdateTaxRates(TaxExemptionDTO TaxExemptionDTO)
        {
            return JsonConvert.SerializeObject(await this.service.UpdateTaxExemption(TaxExemptionDTO));
        }
    }
}
