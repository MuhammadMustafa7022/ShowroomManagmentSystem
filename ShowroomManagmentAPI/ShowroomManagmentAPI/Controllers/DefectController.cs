using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefectController : ControllerBase
    {
        private readonly IDefect service;
        public DefectController(IDefect service)
        {
            this.service = service;
        }

        [HttpGet("GetDefect")]
        public async Task<string> GetDefect()
        {
            return JsonConvert.SerializeObject(await this.service.GetDefect());
        }
        [HttpPost("AddDefect")]
        public async Task<string> AddDefect(DefectDTO defectDTO)
        {
            return JsonConvert.SerializeObject(await this.service.AddDefect(defectDTO));

        }
        [HttpGet("DeleteDefect/{id}")]
        public async Task<string> DeleteDefect(int id)
        {
            return JsonConvert.SerializeObject(await this.service.DeleteDefect(id));
        }
        [HttpGet("GetDefectById/{id}")]
        public async Task<string> GetDefectById(int id)
        {
            return JsonConvert.SerializeObject(await this.service.GetDefectById(id));
        }
        [HttpPost("UpdateDefect")]
        public async Task<string> UpdateDefect(DefectDTO defectDTO)
        {
            return JsonConvert.SerializeObject(await this.service.UpdateDefect(defectDTO));
        }
    }
}
