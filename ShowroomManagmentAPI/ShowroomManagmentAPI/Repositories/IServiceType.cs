using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IServiceType
    {
        public Task<ResponseDTO> GetServiceType();
        public Task<ResponseDTO> AddServiceType(ServiceTypeDTO serviceTypeDTO);
        public Task<ResponseDTO> GetServiceTypeById(int id);
        public Task<ResponseDTO> DeleteServiceType(int id);
        public Task<ResponseDTO> UpdateServiceType(ServiceTypeDTO serviceTypeDTO);
    }
}
