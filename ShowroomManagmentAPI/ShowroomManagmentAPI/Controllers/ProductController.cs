using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct service;
        public ProductController(IProduct service)
        {
            this.service = service;

        }

        [HttpGet("GetProduct")]
        public async Task<string> GetProduct()
        {
            return JsonConvert.SerializeObject(await service.GetProduct());
        }

        [HttpPost("AddProduct")]
        public async Task<string> AddProduct(ProductDTO ProductDTO)
        {
            return JsonConvert.SerializeObject(await service.AddProduct(ProductDTO));
        }

        [HttpGet("DeleteProduct/{id}")]
        public async Task<string> DeleteProduct(int id)
        {
            return JsonConvert.SerializeObject(await service.DeleteProduct(id));
        }

        [HttpGet("GetProductById/{id}")]
        public async Task<string> GetProductById(int id)
        {
            return JsonConvert.SerializeObject(await service.GetProductById(id));
        }

        [HttpPost("UpdateProduct")]
        public async Task<string> UpdateProduct(ProductDTO ProductDTO)
        {
            return JsonConvert.SerializeObject(await service.UpdateProduct(ProductDTO));
        }
    }
}
