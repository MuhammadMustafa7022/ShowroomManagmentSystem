using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface ITaxExemption
    {
        public Task<ResponseDTO> GetTaxExemption();
        public Task<ResponseDTO> AddTaxExemption(TaxExemptionDTO taxExemptionDTO);
        public Task<ResponseDTO> GetTaxExemptionById(int id);
        public Task<ResponseDTO> DeleteTaxExemption(int id);
        public Task<ResponseDTO> UpdateTaxExemption(TaxExemptionDTO taxExemptionDTO);
    }
}
