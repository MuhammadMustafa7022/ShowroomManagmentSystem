using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategory Service;

        public CategoryController(ICategory service)
        {
            Service = service;
        }

        [HttpGet("GetCategory")]
        public async Task<string> GetCategory()
        {
            return JsonConvert.SerializeObject(await Service.GetCategory());
        }

        [HttpPost("AddCategory")]
        public async Task<string> AddCategory(CategoryDTO CategoryDTO)
        {
            return JsonConvert.SerializeObject(await Service.AddCategory(CategoryDTO));
        }


        [HttpGet("GetCategoryById/{id}")]
        public async Task<string> GetCategoryById(int id)
        {
            return JsonConvert.SerializeObject(await Service.GetCategoryById(id));
        }


        [HttpGet("DeleteCategory/{id}")]
        public async Task<string> DeleteCategory(int id)
        {
            return JsonConvert.SerializeObject(await Service.DeleteCategory(id));
        }


        [HttpPost("UpdateCategory")]
        public async Task<string> UpdateCategory(CategoryDTO CategoryDTO)
        {
            return JsonConvert.SerializeObject(await Service.UpdateCategory(CategoryDTO));
        }


    }
}
