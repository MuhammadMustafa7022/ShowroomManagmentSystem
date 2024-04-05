using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface ISupplier
    {
        public Task<ResponseDTO> GetSupplier();
        public Task<ResponseDTO> AddSupplier(SupplierDTO SupplierDTO);
        public Task<ResponseDTO> DeleteSupplier(int Id);
        public Task<ResponseDTO> GetSupplierById(int Id);
        public Task<ResponseDTO> UpdateSupplier(SupplierDTO SupplierDTO);

    }
}
