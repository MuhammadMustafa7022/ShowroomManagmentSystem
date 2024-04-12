using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceAppointmentController : ControllerBase
    {
        private readonly IServiceAppointment service;
        public ServiceAppointmentController(IServiceAppointment service)
        {
            this.service = service;

        }
        [HttpGet("GetServiceAppointment")]
        public async Task<string> GetServiceAppointment()
        {
            return JsonConvert.SerializeObject(await service.GetServiceAppointment());
        }
        [HttpPost("AddServiceAppointment")]
        public async Task<string> AddServiceAppointment(ServiceAppointmentDTO serviceAppointmentDTO)
        {
            return JsonConvert.SerializeObject(await service.AddServiceAppointment(serviceAppointmentDTO));
        }
        [HttpGet("DeleteServiceAppointment/{id}")]
        public async Task<string> DeleteServiceAppointment(int Id)
        {
            return JsonConvert.SerializeObject(await service.DeleteServiceAppointment(Id));
        }
        [HttpGet("GetServiceAppointmentById/{id}")]
        public async Task<string> GetServiceAppointmentById(int Id)
        {
            return JsonConvert.SerializeObject(await service.GetServiceAppointmentById(Id));
        }
        [HttpPost("UpdateServiceAppointment")]
        public async Task<string> UpdateServiceAppointment(ServiceAppointmentDTO serviceAppointmentDTO)
        {
            return JsonConvert.SerializeObject(await service.UpdateServiceAppointment(serviceAppointmentDTO));
        }
    }
}
