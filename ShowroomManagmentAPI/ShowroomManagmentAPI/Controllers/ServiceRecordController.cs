using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceRecordController : ControllerBase
    {
        private readonly IServiceRecord service;
        public ServiceRecordController(IServiceRecord service)
        {
            this.service = service;

        }
        [HttpGet("GetServiceRecord")]
        public async Task<string> GetServiceRecord()
        {
            return JsonConvert.SerializeObject(await service.GetServiceRecord());
        }
        [HttpPost("AddServiceRecord")]
        public async Task<string> AddServiceRecord(ServiceRecordDTO serviceRecordDTO)
        {
            return JsonConvert.SerializeObject(await service.AddServiceRecord(serviceRecordDTO));
        }
        [HttpGet("DeleteServiceRecord/{id}")]
        public async Task<string> DeleteServiceRecord(int Id)
        {
            return JsonConvert.SerializeObject(await service.DeleteServiceRecord(Id));
        }
        [HttpGet("GetServiceRecordById/{id}")]
        public async Task<string> GetServiceRecordById(int Id)
        {
            return JsonConvert.SerializeObject(await service.GetServiceRecordById(Id));
        }
        [HttpPost("UpdateServiceRecord")]
        public async Task<string> UpdateServiceRecord(ServiceRecordDTO serviceRecordDTO)
        {
            return JsonConvert.SerializeObject(await service.UpdateServiceRecord(serviceRecordDTO));
        }
    }
}
