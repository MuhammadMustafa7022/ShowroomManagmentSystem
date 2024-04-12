using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Tax_Configuration_Module
{
    public class TaxExemptionModel : ITaxExemption
    {
        private readonly ApplicationDbContext context;
        public TaxExemptionModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> GetTaxExemption()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.TaxExemptions.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> AddTaxExemption(TaxExemptionDTO taxExemptionDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var taxExemption = new TaxExemption()
                {
                    ExemptionType = taxExemptionDTO.ExemptionType,
                    Description = taxExemptionDTO.Description,
                    ApplicableProduct = taxExemptionDTO.ApplicableProduct,
                    EffectiveDate = taxExemptionDTO.EffectiveDate,
                    EndDate = taxExemptionDTO.EndDate,
                };
                await context.TaxExemptions.AddAsync(taxExemption);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "TaxExemption Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> GetTaxExemptionById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.TaxExemptions.Where(x => x.PkId == id).FirstOrDefaultAsync();
                if (data != null)
                {
                    ResponseDTO.Response = data;
                }
                else
                {
                    ResponseDTO.StatusCode = 404;
                }
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> DeleteTaxExemption(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.TaxExemptions.Where(x => x.PkId == id).FirstOrDefaultAsync();
                if (data != null)
                {
                    context.TaxExemptions.Remove(data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "TaxExemption Deleted";
                }
                else
                {
                    ResponseDTO.StatusCode = 404;
                }
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> UpdateTaxExemption(TaxExemptionDTO taxExemptionDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var TaxExemption = new TaxExemption()
                {
                    PkId = taxExemptionDTO.PkId,
                    ExemptionType = taxExemptionDTO.ExemptionType,
                    Description = taxExemptionDTO.Description,
                    ApplicableProduct = taxExemptionDTO.ApplicableProduct,
                    EffectiveDate = taxExemptionDTO.EffectiveDate,
                    EndDate = taxExemptionDTO.EndDate,
                };
                context.TaxExemptions.Update(TaxExemption);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "TaxExemption Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
