using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Tax_Configuration_Module
{
    public class TaxRatesModel : ITaxRates
    {
        private readonly ApplicationDbContext context;
        public TaxRatesModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> GetTaxRates()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.TaxRates.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> AddTaxRates(TaxRateDTO taxRateDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var TaxRate = new TaxRate()
                {
                    TaxType = taxRateDTO.TaxType,
                    Rate = taxRateDTO.Rate,
                    Description = taxRateDTO.Description,
                    EffectiveDate = taxRateDTO.EffectiveDate,
                    Enddate = taxRateDTO.EndDate,
                };
                await context.TaxRates.AddAsync(TaxRate);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "TaxRate Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> GetTaxRatesById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.TaxRates.Where(x => x.PkId == id).FirstOrDefaultAsync();
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
        public async Task<ResponseDTO> DeleteTaxRates(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.TaxRates.Where(x=>x.PkId == id).FirstOrDefaultAsync();
                if(data != null)
                {
                    context.TaxRates.Remove(data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "TaxRates Deletede";
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
        public async Task<ResponseDTO> UpdateTaxRates(TaxRateDTO taxRateDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var TaxRate = new TaxRate()
                {
                    PkId = taxRateDTO.PkId,
                    TaxType = taxRateDTO.TaxType,
                    Rate = taxRateDTO.Rate,
                    Description = taxRateDTO.Description,
                    EffectiveDate = taxRateDTO.EffectiveDate,
                    Enddate = taxRateDTO.EndDate,
                };
                context.TaxRates.Update(TaxRate);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "TaxRate Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
