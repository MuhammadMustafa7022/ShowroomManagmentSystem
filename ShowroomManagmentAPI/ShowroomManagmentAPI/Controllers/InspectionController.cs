using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectionController : ControllerBase
    {
        private readonly IInspection service;
        public InspectionController(IInspection service)
        {
            this.service = service;
        }
        [HttpGet("GetInspection")]
        public async Task<string> GetInspection()
        {
            return JsonConvert.SerializeObject(await this.service.GetInspection());
        }
        [HttpPost("AddInspection")]
        public async Task<string> AddInspection(InspectionDTO inspectionDTO)
        {
            return JsonConvert.SerializeObject(await this.service.AddInspection(inspectionDTO));
        }
        [HttpGet("GetInspectionById/{id}")]
        public async Task<string> GetInspectionById(int id)
        {
            return JsonConvert.SerializeObject(await this.service.GetInspectionById(id));
        }
        [HttpGet("DeleteInspection/{id}")]
        public async Task<string> DeleteInspection(int id)
        {
            return JsonConvert.SerializeObject(await this.service.DeleteInspection(id));
        }
        [HttpPost("UpdateInspection")]
        public async Task<string> UpdateInspection(InspectionDTO inspectionDTO)
        {
            return JsonConvert.SerializeObject(await this.service.UpdateInspection(inspectionDTO));
        }
    }
}
