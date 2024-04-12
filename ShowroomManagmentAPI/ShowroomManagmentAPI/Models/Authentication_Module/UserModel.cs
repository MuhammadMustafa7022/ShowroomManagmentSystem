using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Authentication_Module
{
    public class UserModel : IUser
    {
        private readonly ApplicationDbContext context;
        public UserModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> AddUser(UserDTO userDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var User = new User()
                {
                    UserName = userDTO.UserName,
                    Password = userDTO.Password,
                    Email = userDTO.Email,
                    FKRoleId = userDTO.FKRoleId,
                };
                await context.Users.AddAsync(User);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "User Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> DeleteUser(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Users.Where(x => x.PkId == id).FirstOrDefaultAsync();
                if (Data != null)
                {
                    context.Users.Remove(Data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "User Deleted";
                }
                else
                {
                    ResponseDTO.StatusCode = 404;
                }

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> GetUser()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.Users.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> GetUserById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Users.Where(x => x.PkId == id).FirstOrDefaultAsync();
                if(Data  != null)
                {
                    ResponseDTO.Response = Data;
                }
                else
                {
                    ResponseDTO.StatusCode = 404;
                }

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> UpdateUser(UserDTO userDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var User = new User()
                {
                    PkId = userDTO.PkId,
                    UserName = userDTO.UserName,
                    Password = userDTO.Password,
                    Email = userDTO.Email,
                    FKRoleId = userDTO.FKRoleId,
                };
                context.Users.Update(User);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "User Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
