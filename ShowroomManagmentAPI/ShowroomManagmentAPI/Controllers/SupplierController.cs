using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplier Service;

        public SupplierController(ISupplier service)
        {
            Service = service;
        }

        [HttpGet("GetSupplier")]
        public async Task<string> GetSupplier()
        {
            return JsonConvert.SerializeObject(await Service.GetSupplier());
        }

        [HttpPost("AddSupplier")]
        public async Task<string> AddSupplier(SupplierDTO SupplierDTO)
        {
            return JsonConvert.SerializeObject(await Service.AddSupplier(SupplierDTO));
        }


        [HttpGet("GetSupplierById/{id}")]
        public async Task<string> GetSupplierById(int id)
        {
            return JsonConvert.SerializeObject(await Service.GetSupplierById(id));
        }


        [HttpGet("DeleteSupplier/{id}")]
        public async Task<string> DeleteSupplier(int id)
        {
            return JsonConvert.SerializeObject(await Service.DeleteSupplier(id));
        }


        [HttpPost("UpdateSupplier")]
        public async Task<string> UpdateSupplier(SupplierDTO SupplierDTO) 
        {
            return JsonConvert.SerializeObject(await Service.UpdateSupplier(SupplierDTO));
        }


    }
}
