using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IInspection
    {
        public Task<ResponseDTO> GetInspection();
        public Task<ResponseDTO> AddInspection(InspectionDTO inspectionDTO);
        public Task<ResponseDTO> GetInspectionById(int id);
        public Task<ResponseDTO> DeleteInspection(int id);
        public Task<ResponseDTO> UpdateInspection(InspectionDTO inspectionDTO);
    }
}
