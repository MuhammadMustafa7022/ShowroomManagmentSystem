using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Tax_Configuration_Module
{
    public class TaxRuleModel : ITaxRule
    {
        private readonly ApplicationDbContext context;
        public TaxRuleModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> AddTaxRule(TaxRuleDTO taxRuleDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var TaxRule = new TaxRule()
                {
                    Description = taxRuleDTO.Description,
                    ApplicableProduct = taxRuleDTO.ApplicableProduct,
                    FKTaxRateId = taxRuleDTO.FKTaxRateId,
                    FKTaxExemption = taxRuleDTO.FKTaxExemption,
                };
                await context.TaxRules.AddAsync(TaxRule);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "TaxRule Inserted";
            }
            catch(Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> DeleteTaxRule(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.TaxRules.Where(x => x.PkId == id).FirstOrDefaultAsync();
                if(Data != null)
                {
                    context.TaxRules.Remove(Data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "TaxRule Deleted";
                }
                else
                {
                    ResponseDTO.StatusCode = 404;
                }
            }
            catch(Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> GetTaxRule()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
              ResponseDTO.Response =  await context.TaxRules.ToListAsync();
            }
            catch(Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> GetTaxRuleById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.TaxRules.Where(x => x.PkId == id).FirstOrDefaultAsync();
                if(Data != null)
                {
                    ResponseDTO.Response = Data;
                }
                else
                {
                    ResponseDTO.StatusCode = 404;
                }
            }
            catch(Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> UpdateTaxRule(TaxRuleDTO taxRuleDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var TaxRule = new TaxRule()
                {
                    PkId = taxRuleDTO.PkId,
                    Description = taxRuleDTO.Description,
                    ApplicableProduct = taxRuleDTO.ApplicableProduct,
                    FKTaxRateId = taxRuleDTO.FKTaxRateId,
                    FKTaxExemption = taxRuleDTO.FKTaxExemption,
                };
                context.TaxRules.Update(TaxRule);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "TaxRule Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
