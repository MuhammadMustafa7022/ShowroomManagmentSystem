using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface ITaxRule
    {
        public Task<ResponseDTO> GetTaxRule();
        public Task<ResponseDTO> AddTaxRule(TaxRuleDTO taxRuleDTO);
        public Task<ResponseDTO> GetTaxRuleById(int id);
        public Task<ResponseDTO> DeleteTaxRule(int id);
        public Task<ResponseDTO> UpdateTaxRule(TaxRuleDTO taxRuleDTO);
    }
}
