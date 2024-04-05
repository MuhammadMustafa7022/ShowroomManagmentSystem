using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectorController : ControllerBase
    {
        private readonly IInspector service;
        public InspectorController(IInspector inspector)
        {
            this.service = service;
        }
        [HttpGet("GetInspector")]
        public async Task<string> GetInspector()
        {
            return JsonConvert.SerializeObject(await this.service.GetInspector());
        }
        [HttpPost("AddInspector")]
        public async Task<string> AddInspector(InspectorDTO inspectorDTO)
        {
            return JsonConvert.SerializeObject(await this.service.AddInspector(inspectorDTO));

        }
        [HttpGet("DeleteInspector/{id}")]
        public async Task<string> DeleteInspector(int id)
        {
            return JsonConvert.SerializeObject(await this.service.DeleteInspector(id));
        }
        [HttpGet("GetInspectorById/{id}")]
        public async Task<string> GetInspectorById(int id)
        {
            return JsonConvert.SerializeObject(await this.service.GetInspectorById(id));
        }
        [HttpPost("UpdateInspector")]
        public async Task<string> UpdateInspector(InspectorDTO inspectorDTO)
        {
            return JsonConvert.SerializeObject(await this.service.UpdateInspector(inspectorDTO));
        }
    }
}
