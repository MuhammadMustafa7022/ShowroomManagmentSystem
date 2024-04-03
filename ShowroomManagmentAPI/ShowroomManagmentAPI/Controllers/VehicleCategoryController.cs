using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleCategoryController : Controller
    {
        public readonly IVehicleCategory Service;
        public VehicleCategoryController(IVehicleCategory _Service)
        {
            this.Service = _Service;
        }

        [HttpGet("GetVehicleCategory")]
        public async Task<string> GetVehicleCategory()
        {
            return JsonConvert.SerializeObject(await this.Service.GetVehicleCategory());
        }

        [HttpPost("AddVehicleCategory")]
        public async Task<string> AddVehicleCategory(VehicleCategoryDTO VehicleCategory)
        {
            return JsonConvert.SerializeObject(await this.Service.AddVehicleCategory(VehicleCategory));
        }

        [HttpGet("GetVehicleCategoryById/{id}")]
        public async Task<string> GetVehicleCategoryById(int Id)
        {
            return JsonConvert.SerializeObject(await this.Service.GetVehicleCategoryById(Id));
        }

        [HttpGet("DeleteVehicleCategory/{id}")]
        public async Task<string> DeleteVehicleCategory(int Id)
        {
            return JsonConvert.SerializeObject(await this.Service.DeleteVehicleCategory(Id));
        }

        [HttpPost("UpdateVehicleCategory")]
        public async Task<string> UpdateVehicleCategory(VehicleCategoryDTO VehicleCategory)
        {
            return JsonConvert.SerializeObject(await this.Service.UpdateVehicleCategory(VehicleCategory));
        }
    }
}
