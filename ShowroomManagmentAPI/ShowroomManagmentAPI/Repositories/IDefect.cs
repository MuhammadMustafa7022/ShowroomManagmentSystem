using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IDefect
    {
        public Task<ResponseDTO> GetDefect();
        public Task<ResponseDTO> AddDefect(DefectDTO defectDTO);
        public Task<ResponseDTO> GetDefectById(int id);
        public Task<ResponseDTO> UpdateDefect(DefectDTO defectDTO);
        public Task<ResponseDTO> DeleteDefect(int id);

    }
}
