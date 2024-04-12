using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface ITaxRates
    {
        public Task<ResponseDTO> GetTaxRates();
        public Task<ResponseDTO> AddTaxRates(TaxRateDTO taxRateDTO);
        public Task<ResponseDTO> GetTaxRatesById(int id);
        public Task<ResponseDTO> DeleteTaxRates(int id);
        public Task<ResponseDTO> UpdateTaxRates(TaxRateDTO taxRateDTO);
        
    }
}
