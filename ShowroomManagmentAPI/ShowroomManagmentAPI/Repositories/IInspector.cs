using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IInspector
    {
        public Task<ResponseDTO> GetInspector();
        public Task<ResponseDTO> AddInspector(InspectorDTO inspectorDTO);
        public Task<ResponseDTO> GetInspectorById(int id);
        public Task<ResponseDTO> DeleteInspector(int id);
        public Task<ResponseDTO> UpdateInspector(InspectorDTO inspectorDTO);

    }
}
