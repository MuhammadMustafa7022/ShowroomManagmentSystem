using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxRuleController : ControllerBase
    {
        private readonly ITaxRule service;
        public TaxRuleController(ITaxRule service)
        {
            this.service = service;
        }
        [HttpGet("GetTaxRule")]
        public async Task<string> GetTaxRule()
        {
            return JsonConvert.SerializeObject(await this.service.GetTaxRule());
        }
        [HttpPost("AddTaxRule")]
        public async Task<string> AddTaxRule(TaxRuleDTO taxRuleDTO)
        {
            return JsonConvert.SerializeObject(await this.service.AddTaxRule(taxRuleDTO));
        }
        [HttpGet("GetTaxRuleById/{id}")]
        public async Task<string> GetTaxRuleById(int id)
        {
            return JsonConvert.SerializeObject(await this.service.GetTaxRuleById(id));
        }
        [HttpGet("DeleteTaxRule/{id}")]
        public async Task<string> DeleteTaxRule(int id)
        {
            return JsonConvert.SerializeObject(await this.service.DeleteTaxRule(id));
        }
        [HttpPost("UpdateTaxRule")]
        public async Task<string> UpdateTaxRule(TaxRuleDTO taxRuleDTO)
        {
            return JsonConvert.SerializeObject(await this.service.UpdateTaxRule(taxRuleDTO));
        }
    }
}
