using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendance service;
        public AttendanceController(IAttendance service)
        {
            this.service = service;
        }
        [HttpGet("GetAttendance")]
        public async Task<string> GetAttendance()
        {
            return JsonConvert.SerializeObject(await this.service.GetAttendance());
        }
        [HttpPost("AddAttendance")]
        public async Task<string> AddAttendance(AttendanceDTO attendanceDTO)
        {
            return JsonConvert.SerializeObject(await this.service.AddAttendance(attendanceDTO));
        }
        [HttpPost("GetAttendanceByEmployeeId/{id}")]
        public async Task<string> GetAttendanceByEmployeeId(int id)
        {
            return JsonConvert.SerializeObject(await this.service.GetAttendanceByEmployeeId(id));
        }
        [HttpPost("UpdateAttendance")]
        public async Task<string> UpdateAttendance(AttendanceDTO attendanceDTO)
        {
            return JsonConvert.SerializeObject(await this.service.UpdateAttendance(attendanceDTO));
        }
    }
}
