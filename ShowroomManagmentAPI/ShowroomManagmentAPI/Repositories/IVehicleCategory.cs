using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IVehicleCategory
    {
        public Task<ResponseDTO> GetVehicleCategory();

        public Task<ResponseDTO> AddVehicleCategory(VehicleCategoryDTO VehicleCategoryDTO);

        public Task<ResponseDTO> GetVehicleCategoryById(int Id);

        public Task<ResponseDTO> DeleteVehicleCategory(int Id);

        public Task<ResponseDTO> UpdateVehicleCategory(VehicleCategoryDTO VehicleCategoryDTO);
    }
}
