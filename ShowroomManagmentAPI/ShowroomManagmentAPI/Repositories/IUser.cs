using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IUser
    {
        public Task<ResponseDTO> GetUser();
        public Task<ResponseDTO> AddUser(UserDTO userDTO);
        public Task<ResponseDTO> GetUserById(int id);
        public Task<ResponseDTO> UpdateUser(UserDTO userDTO);
        public Task<ResponseDTO> DeleteUser(int id);
    }
}
