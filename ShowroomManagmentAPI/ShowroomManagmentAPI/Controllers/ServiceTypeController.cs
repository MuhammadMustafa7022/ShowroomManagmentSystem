using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceTypeController : ControllerBase
    {
        private readonly IServiceType service;
        public ServiceTypeController(IServiceType service)
        {
            this.service = service;

        }
        [HttpGet("GetServiceType")]
        public async Task<string> GetServiceType()
        {
            return JsonConvert.SerializeObject(await service.GetServiceType());
        }
        [HttpPost("AddServiceType")]
        public async Task<string> AddServiceType(ServiceTypeDTO serviceTypeDTO)
        {
            return JsonConvert.SerializeObject(await service.AddServiceType(serviceTypeDTO));
        }
        [HttpGet("DeleteServiceType/{id}")]
        public async Task<string> DeleteServiceType(int Id)
        {
            return JsonConvert.SerializeObject(await service.DeleteServiceType(Id));
        }
        [HttpGet("GetServiceTypeById/{id}")]
        public async Task<string> GetServiceTypeById(int Id)
        {
            return JsonConvert.SerializeObject(await service.GetServiceTypeById(Id));
        }
        [HttpPost("serviceTypeDTO")]
        public async Task<string> UpdateServiceType(ServiceTypeDTO serviceTypeDTO)
        {
            return JsonConvert.SerializeObject(await service.UpdateServiceType(serviceTypeDTO));
        }
    }
}
