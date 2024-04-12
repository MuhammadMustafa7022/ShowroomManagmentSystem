using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser service;
        public UserController(IUser User)
        {
            this.service = User;
        }

        [HttpGet("GetUser")]
        public async Task<string> GetUser()
        {
            return JsonConvert.SerializeObject(await service.GetUser());
        }
        [HttpPost("AddUser")]
        public async Task<string> AddUser(UserDTO userDTO)
        {
            return JsonConvert.SerializeObject(await service.AddUser(userDTO));
        }
        [HttpGet("GetUserById/{id}")]
        public async Task<string> GetUserById(int id)
        {
            return JsonConvert.SerializeObject(await service.GetUserById(id));
        }
        [HttpGet("DeleteUser/{id}")]
        public async Task<string> DeleteUser(int id)
        {
            return JsonConvert.SerializeObject(await service.DeleteUser(id));
        }
        [HttpPost("UpdateUser")]
        public async Task<string> UpdateUser(UserDTO userDTO)
        {
            return JsonConvert.SerializeObject(await service.UpdateUser(userDTO));
        }
    }
}
