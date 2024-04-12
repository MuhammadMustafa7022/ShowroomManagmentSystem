using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IServiceRecord
    {
        public Task<ResponseDTO> GetServiceRecord();
        public Task<ResponseDTO> AddServiceRecord(ServiceRecordDTO serviceRecordDTO);
        public Task<ResponseDTO> GetServiceRecordById(int id);
        public Task<ResponseDTO> DeleteServiceRecord(int id);
        public Task<ResponseDTO> UpdateServiceRecord(ServiceRecordDTO serviceRecordDTO);
    }
}
